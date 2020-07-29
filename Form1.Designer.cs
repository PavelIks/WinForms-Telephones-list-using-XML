using System.Drawing;
using System.Windows.Forms;

namespace TelephonesListUsingXML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaximumSize = new System.Drawing.Size(623, 285);
            this.ClientSize = new System.Drawing.Size(623, 285);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Telephones List using XML";
            this.Shown += form_Show;
            this.FormClosing += form_Closing;
            //
            //
            //

            Controls.Add(select_Panel);
            Controls.Add(picture);
            Controls.Add(company_text);
            Controls.Add(model_text);
            Controls.Add(price_text);
            Controls.Add(size_text);
            Controls.Add(memory_text);
            //
            //
            //

            select_Panel.Size = new System.Drawing.Size(150,this.Height);
            select_Panel.BackColor = Color.Black;
            select_Panel.Controls.Add(model_list);
            select_Panel.Controls.Add(company_list);
            select_Panel.Controls.Add(delete);

            //
            //
            //

            company_list.Location = new System.Drawing.Point(10, 10);
            company_list.SelectedValueChanged += company_Cnhg;

            //
            //
            //

            model_list.Location = new System.Drawing.Point(10, 40);
            model_list.Enabled = false;
            model_list.SelectedValueChanged += model_Chng;
            //
            //
            //

            picture.Location = new Point(150, 0);
            picture.Size = new Size(250, 250);
            picture.Load("Nokia3310File.jpg");
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            //picture.BackColor = Color.Red;

            //
            //
            //

            company_text.Location = new Point(500, 20);
            company_text.MaxLength = 15;

            //
            //
            //

            model_text.Location = new Point(500, 50);
            model_text.MaxLength = 15;


            //
            //
            //

            price_text.Location = new Point(500, 80);
            price_text.MaxLength = 15;

            //
            //
            //

            size_text.Location = new Point(500,110);
            size_text.MaxLength = 15;

            //
            //
            //

            memory_text.Location = new Point(500, 140);
            company_text.MaxLength = 15;

            //
            //
            //

            delete.Text = "Delete";
            delete.BackColor = Color.White;
            delete.Enabled = false;
            delete.Location = new Point(10, 80);
            delete.Click += delete_Click;
           
        }

        

        Button delete = new Button();
        TextBox company_text = new TextBox();
        TextBox model_text = new TextBox();
        TextBox price_text = new TextBox();
        TextBox size_text = new TextBox();
        TextBox memory_text = new TextBox();
        Panel select_Panel = new Panel();
        ComboBox model_list = new ComboBox();
        ComboBox company_list = new ComboBox();

        PictureBox picture = new PictureBox();
        #endregion
    }
}