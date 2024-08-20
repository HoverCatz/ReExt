using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReExt {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var text = toolTip_installRcCm.ToolTipTitle;
            toolTip_installRcCm.SetToolTip(btn_installRcRm, text);
            toolTip_installRcCm.ToolTipTitle = "";
        }

        private void label1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? 
                DragDropEffects.Copy : DragDropEffects.None;
        }

        private void label1_DragDrop(object sender, DragEventArgs e) {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
                list_preview.Items.Add("Added: " + file);
        }

        private void button4_MouseHover(object sender, EventArgs e) {
            
        }
        
    }
}