namespace LommeregnerGui;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.n1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(200, 78);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(154, 54);
        this.textBox1.TabIndex = 0;
        this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        this.textBox1.Text = "0";
        this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.textBox1.Multiline = true;
        this.textBox1.ReadOnly = true;
        this.textBox1.Dock = System.Windows.Forms.DockStyle.None;
        // 
        // button1
        // 
        this.n1.Location = new System.Drawing.Point(44, 135);
        this.n1.Name = "n1";
        this.n1.Size = new System.Drawing.Size(75, 54);
        this.n1.TabIndex = 1;
        this.n1.Text = "1";
        this.n1.UseVisualStyleBackColor = true;
        this.n1.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n1.Click += new System.EventHandler(this.n1_Click);
        // 
        // button1
        // 
        // 
        // label1
        // 
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(403, 409);
        this.Controls.Add(this.n1);
        this.Controls.Add(this.textBox1);
        this.Name = "Form1";
        Text = "Lommeregner";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.BackColor = System.Drawing.Color.Gray;
        this.HelpButton = false;
        this.n2 = new System.Windows.Forms.Button();
        this.n2.Location = new System.Drawing.Point(122, 135);
        this.n2.Name = "n2";
        this.n2.Size = new System.Drawing.Size(75, 54);
        this.n2.TabIndex = 1;
        this.n2.Text = "2";
        this.n2.UseVisualStyleBackColor = true;
        this.n2.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n2.Click += new System.EventHandler(this.n2_Click);
        this.Controls.Add(this.n2);
        this.n3 = new System.Windows.Forms.Button();
        this.n3.Location = new System.Drawing.Point(200, 135);
        this.n3.Name = "n3";
        this.n3.Size = new System.Drawing.Size(75, 54);
        this.n3.TabIndex = 1;
        this.n3.Text = "3";
        this.n3.UseVisualStyleBackColor = true;
        this.n3.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n3.Click += new System.EventHandler(this.n3_Click);
        this.Controls.Add(this.n3);
        this.n4 = new System.Windows.Forms.Button();
        this.n4.Location = new System.Drawing.Point(44, 192);
        this.n4.Name = "n4";
        this.n4.Size = new System.Drawing.Size(75, 54);
        this.n4.TabIndex = 1;
        this.n4.Text = "4";
        this.n4.UseVisualStyleBackColor = true;
        this.n4.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n4.Click += new System.EventHandler(this.n4_Click);
        this.Controls.Add(this.n4);
        this.n5 = new System.Windows.Forms.Button();
        this.n5.Location = new System.Drawing.Point(122, 192);
        this.n5.Name = "n5";
        this.n5.Size = new System.Drawing.Size(75, 54);
        this.n5.TabIndex = 1;
        this.n5.Text = "5";
        this.n5.UseVisualStyleBackColor = true;
        this.n5.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n5.Click += new System.EventHandler(this.n5_Click);
        this.Controls.Add(this.n5);
        this.n6 = new System.Windows.Forms.Button();
        this.n6.Location = new System.Drawing.Point(200, 192);
        this.n6.Name = "n6";
        this.n6.Size = new System.Drawing.Size(75, 54);
        this.n6.TabIndex = 1;
        this.n6.Text = "6";
        this.n6.UseVisualStyleBackColor = true;
        this.n6.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n6.Click += new System.EventHandler(this.n6_Click);
        this.Controls.Add(this.n6);
        this.n8 = new System.Windows.Forms.Button();
        this.n8.Location = new System.Drawing.Point(122, 251);
        this.n8.Name = "n8";
        this.n8.Size = new System.Drawing.Size(75, 54);
        this.n8.TabIndex = 1;
        this.n8.Text = "8";
        this.n8.UseVisualStyleBackColor = true;
        this.n8.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n8.Click += new System.EventHandler(this.n8_Click);
        this.Controls.Add(this.n8);
        this.n9 = new System.Windows.Forms.Button();
        this.n9.Location = new System.Drawing.Point(200, 251);
        this.n9.Name = "n9";
        this.n9.Size = new System.Drawing.Size(75, 54);
        this.n9.TabIndex = 1;
        this.n9.Text = "9";
        this.n9.UseVisualStyleBackColor = true;
        this.n9.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n9.Click += new System.EventHandler(this.n9_Click);
        this.Controls.Add(this.n9);
        this.n7 = new System.Windows.Forms.Button();
        this.n7.Location = new System.Drawing.Point(44, 251);
        this.n7.Name = "n7";
        this.n7.Size = new System.Drawing.Size(75, 54);
        this.n7.TabIndex = 1;
        this.n7.Text = "7";
        this.n7.UseVisualStyleBackColor = true;
        this.n7.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n7.Click += new System.EventHandler(this.n7_Click);
        this.Controls.Add(this.n7);
        this.n0 = new System.Windows.Forms.Button();
        this.n0.Location = new System.Drawing.Point(122, 308);
        this.n0.Name = "n0";
        this.n0.Size = new System.Drawing.Size(75, 54);
        this.n0.TabIndex = 1;
        this.n0.Text = "0";
        this.n0.UseVisualStyleBackColor = true;
        this.n0.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.n0.Click += new System.EventHandler(this.n0_Click);
        this.Controls.Add(this.n0);
        this.bc = new System.Windows.Forms.Button();
        this.bc.Location = new System.Drawing.Point(44, 308);
        this.bc.Name = "bc";
        this.bc.Size = new System.Drawing.Size(75, 54);
        this.bc.TabIndex = 1;
        this.bc.Text = "C";
        this.bc.UseVisualStyleBackColor = true;
        this.bc.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.bc.Click += new System.EventHandler(this.bc_Click);
        this.Controls.Add(this.bc);
        this.bequal = new System.Windows.Forms.Button();
        this.bequal.Location = new System.Drawing.Point(44, 78);
        this.bequal.Name = "bequal";
        this.bequal.Size = new System.Drawing.Size(156, 54);
        this.bequal.TabIndex = 1;
        this.bequal.Text = "=";
        this.bequal.UseVisualStyleBackColor = true;
        this.bequal.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.bequal.Click += new System.EventHandler(this.bequal_Click);
        this.Controls.Add(this.bequal);
        this.bsub = new System.Windows.Forms.Button();
        this.bsub.Location = new System.Drawing.Point(278, 192);
        this.bsub.Name = "bsub";
        this.bsub.Size = new System.Drawing.Size(75, 54);
        this.bsub.TabIndex = 1;
        this.bsub.Text = "-";
        this.bsub.UseVisualStyleBackColor = true;
        this.bsub.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.bsub.Click += new System.EventHandler(this.bsub_Click);
        this.Controls.Add(this.bsub);
        this.bmult = new System.Windows.Forms.Button();
        this.bmult.Location = new System.Drawing.Point(278, 251);
        this.bmult.Name = "bmult";
        this.bmult.Size = new System.Drawing.Size(75, 54);
        this.bmult.TabIndex = 1;
        this.bmult.Text = "*";
        this.bmult.UseVisualStyleBackColor = true;
        this.bmult.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.bmult.Click += new System.EventHandler(this.bmult_Click);
        this.Controls.Add(this.bmult);
        this.bdiv = new System.Windows.Forms.Button();
        this.bdiv.Location = new System.Drawing.Point(278, 308);
        this.bdiv.Name = "bdiv";
        this.bdiv.Size = new System.Drawing.Size(75, 54);
        this.bdiv.TabIndex = 1;
        this.bdiv.Text = "/";
        this.bdiv.UseVisualStyleBackColor = true;
        this.bdiv.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
        this.Controls.Add(this.bdiv);
        this.bad = new System.Windows.Forms.Button();
        this.bad.Location = new System.Drawing.Point(278, 135);
        this.bad.Name = "bad";
        this.bad.Size = new System.Drawing.Size(75, 54);
        this.bad.TabIndex = 1;
        this.bad.Text = "+";
        this.bad.UseVisualStyleBackColor = true;
        this.bad.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.bad.Click += new System.EventHandler(this.bad_Click);
        this.Controls.Add(this.bad);
        this.ndot = new System.Windows.Forms.Button();
        this.ndot.Location = new System.Drawing.Point(200, 308);
        this.ndot.Name = "ndot";
        this.ndot.Size = new System.Drawing.Size(75, 54);
        this.ndot.TabIndex = 1;
        this.ndot.Text = ",";
        this.ndot.UseVisualStyleBackColor = true;
        this.ndot.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.ndot.Click += new System.EventHandler(this.ndot_Click);
        this.Controls.Add(this.ndot);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button n1;
    private System.Windows.Forms.Button n2;
    private System.Windows.Forms.Button n3;
    private System.Windows.Forms.Button n4;
    private System.Windows.Forms.Button n5;
    private System.Windows.Forms.Button n6;
    private System.Windows.Forms.Button n8;
    private System.Windows.Forms.Button n9;
    private System.Windows.Forms.Button n7;
    private System.Windows.Forms.Button n0;
    private System.Windows.Forms.Button bc;
    private System.Windows.Forms.Button bequal;
    private System.Windows.Forms.Button bsub;
    private System.Windows.Forms.Button bmult;
    private System.Windows.Forms.Button bdiv;
    private System.Windows.Forms.Button bad;
    private System.Windows.Forms.Button ndot;

}
