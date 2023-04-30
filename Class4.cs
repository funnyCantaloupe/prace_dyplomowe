using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prace_dyplomowe
{
    public class Form6 : Form2
    {


        public Form6(Form2 form2) : base()
        {
            this.label27.Hide();
            this.textBox23.Hide();
            this.label28.Hide();
            this.textBox24.Hide();
            this.label29.Hide();
            this.textBox25.Hide();
            this.label8.Hide();
            this.textBox8.Hide();
            this.label26.Hide();
            this.textBox22.Hide();
            this.label9.Hide();
            this.textBox9.Hide();
            this.label10.Hide();
            this.textBox10.Hide();
            this.label11.Hide();
            this.textBox11.Hide();
            this.label14.Hide();
            this.label18.Hide();
            this.textBox14.Hide();
            this.label22.Hide();
            this.textBox18.Hide();
            this.label15.Hide();
            this.label19.Hide();
            this.textBox15.Hide();
            this.label23.Hide();
            this.textBox19.Hide();
            this.label16.Hide();
            this.label20.Hide();
            this.textBox16.Hide();
            this.label24.Hide();
            this.textBox20.Hide();
            this.label13.Hide();
            this.label17.Hide();
            this.textBox13.Hide();
            this.label21.Hide();
            this.textBox17.Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(875, 621);
            this.Name = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
