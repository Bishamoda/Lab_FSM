
namespace FSM_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_z1 = new System.Windows.Forms.Button();
            this.btn_z2 = new System.Windows.Forms.Button();
            this.btn_z3 = new System.Windows.Forms.Button();
            this.btn_z4 = new System.Windows.Forms.Button();
            this.txt_StartState = new System.Windows.Forms.TextBox();
            this.txt_CurrentState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pictureBox_w1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_w2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_w3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_w4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_z1
            // 
            this.btn_z1.Location = new System.Drawing.Point(57, 204);
            this.btn_z1.Name = "btn_z1";
            this.btn_z1.Size = new System.Drawing.Size(75, 39);
            this.btn_z1.TabIndex = 0;
            this.btn_z1.Text = "Z1";
            this.btn_z1.UseVisualStyleBackColor = true;
            this.btn_z1.Click += new System.EventHandler(this.btn_z1_Click);
            // 
            // btn_z2
            // 
            this.btn_z2.Location = new System.Drawing.Point(149, 206);
            this.btn_z2.Name = "btn_z2";
            this.btn_z2.Size = new System.Drawing.Size(75, 37);
            this.btn_z2.TabIndex = 1;
            this.btn_z2.Text = "Z2";
            this.btn_z2.UseVisualStyleBackColor = true;
            this.btn_z2.Click += new System.EventHandler(this.btn_z2_Click);
            // 
            // btn_z3
            // 
            this.btn_z3.Location = new System.Drawing.Point(57, 261);
            this.btn_z3.Name = "btn_z3";
            this.btn_z3.Size = new System.Drawing.Size(75, 35);
            this.btn_z3.TabIndex = 2;
            this.btn_z3.Text = "Z3";
            this.btn_z3.UseVisualStyleBackColor = true;
            this.btn_z3.Click += new System.EventHandler(this.btn_z3_Click);
            // 
            // btn_z4
            // 
            this.btn_z4.Location = new System.Drawing.Point(149, 261);
            this.btn_z4.Name = "btn_z4";
            this.btn_z4.Size = new System.Drawing.Size(75, 35);
            this.btn_z4.TabIndex = 3;
            this.btn_z4.Text = "Z4";
            this.btn_z4.UseVisualStyleBackColor = true;
            this.btn_z4.Click += new System.EventHandler(this.btn_z4_Click);
            // 
            // txt_StartState
            // 
            this.txt_StartState.Location = new System.Drawing.Point(65, 72);
            this.txt_StartState.Name = "txt_StartState";
            this.txt_StartState.Size = new System.Drawing.Size(100, 20);
            this.txt_StartState.TabIndex = 5;
            // 
            // txt_CurrentState
            // 
            this.txt_CurrentState.Location = new System.Drawing.Point(65, 146);
            this.txt_CurrentState.Name = "txt_CurrentState";
            this.txt_CurrentState.Size = new System.Drawing.Size(100, 20);
            this.txt_CurrentState.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Начальное состояние";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текущее состояние";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(335, 251);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(74, 35);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // pictureBox_w1
            // 
            this.pictureBox_w1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_w1.Location = new System.Drawing.Point(335, 36);
            this.pictureBox_w1.Name = "pictureBox_w1";
            this.pictureBox_w1.Size = new System.Drawing.Size(38, 30);
            this.pictureBox_w1.TabIndex = 14;
            this.pictureBox_w1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "W1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "W2";
            // 
            // pictureBox_w2
            // 
            this.pictureBox_w2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_w2.Location = new System.Drawing.Point(335, 87);
            this.pictureBox_w2.Name = "pictureBox_w2";
            this.pictureBox_w2.Size = new System.Drawing.Size(38, 30);
            this.pictureBox_w2.TabIndex = 16;
            this.pictureBox_w2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "W3";
            // 
            // pictureBox_w3
            // 
            this.pictureBox_w3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_w3.Location = new System.Drawing.Point(335, 134);
            this.pictureBox_w3.Name = "pictureBox_w3";
            this.pictureBox_w3.Size = new System.Drawing.Size(38, 30);
            this.pictureBox_w3.TabIndex = 18;
            this.pictureBox_w3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "W4";
            // 
            // pictureBox_w4
            // 
            this.pictureBox_w4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_w4.Location = new System.Drawing.Point(335, 181);
            this.pictureBox_w4.Name = "pictureBox_w4";
            this.pictureBox_w4.Size = new System.Drawing.Size(38, 30);
            this.pictureBox_w4.TabIndex = 20;
            this.pictureBox_w4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox_w4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox_w3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_w2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_w1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CurrentState);
            this.Controls.Add(this.txt_StartState);
            this.Controls.Add(this.btn_z4);
            this.Controls.Add(this.btn_z3);
            this.Controls.Add(this.btn_z2);
            this.Controls.Add(this.btn_z1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа АДБ-17-07 Щипакин М.А.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_z1;
        private System.Windows.Forms.Button btn_z2;
        private System.Windows.Forms.Button btn_z3;
        private System.Windows.Forms.Button btn_z4;
        private System.Windows.Forms.TextBox txt_StartState;
        private System.Windows.Forms.TextBox txt_CurrentState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.PictureBox pictureBox_w1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_w2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_w3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_w4;
    }
}

