using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.SDX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VertexGatherer
{
    public partial class CtrlForm : Form
    {
        IPERunArgs args;
        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
        }

        private void CtrlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            IPXPmx pmx = args.Host.Connector.Pmx.GetCurrentState();
            int[] selectedVertexIndices = args.Host.Connector.View.PmxView.GetSelectedVertexIndices();


            var position = new V3();
            var normal = new V3();
            List<(IPXBone bone, float weight)> weight = new List<(IPXBone, float)>();
            var uv = new V2();

            //総和
            foreach (var i in selectedVertexIndices)
            {
                if (checkBoxPosition.Checked)
                    position += pmx.Vertex[i].Position;
                if (checkBoxNormal.Checked)
                    normal += pmx.Vertex[i].Normal;
                if (checkBoxWeight.Checked)
                {
                    var vw = GetVertexBoneWithWeight(pmx.Vertex[i]);
                    weight.AddRange(vw);
                }
                if (checkBoxUV.Checked)
                    uv += pmx.Vertex[i].UV;
            }

            //平均
            if (checkBoxPosition.Checked)
                position /= selectedVertexIndices.Length;
            if (checkBoxNormal.Checked)
                normal /= selectedVertexIndices.Length;
            if (checkBoxWeight.Checked)
                weight = weight.GroupBy(w => w.bone, v => v.weight).Select(g => (g.Key, g.Sum() / selectedVertexIndices.Length)).ToList();
            if (checkBoxUV.Checked)
                uv /= selectedVertexIndices.Length;

            //反映
            foreach (var i in selectedVertexIndices)
            {
                if (checkBoxPosition.Checked)
                    pmx.Vertex[i].Position = position;
                if (checkBoxNormal.Checked)
                    pmx.Vertex[i].Normal = normal;
                if (checkBoxWeight.Checked)
                {
                    var v = pmx.Vertex[i];
                    SetVertexWeight(weight, ref v);
                    pmx.Vertex[i] = v;
                }
                if (checkBoxUV.Checked)
                    pmx.Vertex[i].UV = uv;
            }

            Methods.Update(args.Host.Connector, pmx, PmxUpdateObject.Vertex);
        }

        private List<(IPXBone bone, float weight)> GetVertexBoneWithWeight(IPXVertex v)
        {
            var weights = new List<(IPXBone bone, float weight)>();
            weights.Add((v.Bone1, v.Weight1));
            weights.Add((v.Bone2, v.Weight2));
            weights.Add((v.Bone3, v.Weight3));
            weights.Add((v.Bone4, v.Weight4));
            return weights;
        }

        private void SetVertexWeight(List<(IPXBone bone, float weight)> weights, ref IPXVertex vertex)
        {
            //降順でソート
            weights.Sort((v, w) => w.weight.CompareTo(v.weight));

            //大きい方から4つまでを残す
            var weight = new List<(IPXBone bone, float weight)>();
            for (int i = 0; i < weights.Count; i++)
            {
                weight.Add(weights[i]);
                if (i > 3)
                    break;
            }

            //正規化
            var max = weight.Select(w => w.weight).Max();
            weight = weight.Select(w => (w.bone, w.weight / max)).ToList();

            //頂点に入力
            vertex.Bone1 = weight[0].bone;
            vertex.Weight1 = weight[0].weight;
            if (weight.Count > 1)
            {
                vertex.Bone2 = weight[1].bone;
                vertex.Weight2 = weight[1].weight;
            }
            if (weight.Count > 2)
            {
                vertex.Bone3 = weight[2].bone;
                vertex.Weight3 = weight[2].weight;
            }
            if (weight.Count > 3)
            {
                vertex.Bone4 = weight[3].bone;
                vertex.Weight4 = weight[3].weight;
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    tabControlMain.Size = new System.Drawing.Size(187, 145);
                    ClientSize = new System.Drawing.Size(187, 146);
                    break;
                case 1:
                    tabControlMain.Size = new System.Drawing.Size(285, 145);
                    ClientSize = new System.Drawing.Size(284, 146);
                    break;
                default:
                    break;
            }
        }
    }
}