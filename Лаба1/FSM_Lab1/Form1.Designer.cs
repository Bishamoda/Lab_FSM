
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
            this.w1 = new System.Windows.Forms.CheckBox();
            this.w2 = new System.Windows.Forms.CheckBox();
            this.w3 = new System.Windows.Forms.CheckBox();
            this.w4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_z1
            // 
            this.btn_z1.Location = new System.Drawing.Point(12, 51);
            this.btn_z1.Name = "btn_z1";
            this.btn_z1.Size = new System.Drawing.Size(75, 39);
            this.btn_z1.TabIndex = 0;
            this.btn_z1.Text = "Z1";
            this.btn_z1.UseVisualStyleBackColor = true;
            this.btn_z1.Click += new System.EventHandler(this.btn_z1_Click);
            // 
            // btn_z2
            // 
            this.btn_z2.Location = new System.Drawing.Point(12, 106);
            this.btn_z2.Name = "btn_z2";
            this.btn_z2.Size = new System.Drawing.Size(75, 37);
            this.btn_z2.TabIndex = 1;
            this.btn_z2.Text = "Z2";
            this.btn_z2.UseVisualStyleBackColor = true;
            this.btn_z2.Click += new System.EventHandler(this.btn_z2_Click);
            // 
            // btn_z3
            // 
            this.btn_z3.Location = new System.Drawing.Point(12, 158);
            this.btn_z3.Name = "btn_z3";
            this.btn_z3.Size = new System.Drawing.Size(75, 35);
            this.btn_z3.TabIndex = 2;
            this.btn_z3.Text = "Z3";
            this.btn_z3.UseVisualStyleBackColor = true;
            this.btn_z3.Click += new System.EventHandler(this.btn_z3_Click);
            // 
            // btn_z4
            // 
            this.btn_z4.Location = new System.Drawing.Point(12, 211);
            this.btn_z4.Name = "btn_z4";
            this.btn_z4.Size = new System.Drawing.Size(75, 35);
            this.btn_z4.TabIndex = 3;
            this.btn_z4.Text = "Z4";
            this.btn_z4.UseVisualStyleBackColor = true;
            this.btn_z4.Click += new System.EventHandler(this.btn_z4_Click);
            // 
            // txt_StartState
            // 
            this.txt_StartState.Location = new System.Drawing.Point(157, 51);
            this.txt_StartState.Name = "txt_StartState";
            this.txt_StartState.Size = new System.Drawing.Size(100, 20);
            this.txt_StartState.TabIndex = 5;
            // 
            // txt_CurrentState
            // 
            this.txt_CurrentState.Location = new System.Drawing.Point(157, 125);
            this.txt_CurrentState.Name = "txt_CurrentState";
            this.txt_CurrentState.Size = new System.Drawing.Size(100, 20);
            this.txt_CurrentState.TabIndex = 6;
            // 
            // w1
            // 
            this.w1.AutoSize = true;
            this.w1.Location = new System.Drawing.Point(313, 53);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(43, 17);
            this.w1.TabIndex = 7;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            // 
            // w2
            // 
            this.w2.AutoSize = true;
            this.w2.Location = new System.Drawing.Point(313, 88);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(43, 17);
            this.w2.TabIndex = 8;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            // 
            // w3
            // 
            this.w3.AutoSize = true;
            this.w3.Location = new System.Drawing.Point(313, 125);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(43, 17);
            this.w3.TabIndex = 9;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            // 
            // w4
            // 
            this.w4.AutoSize = true;
            this.w4.Location = new System.Drawing.Point(313, 158);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(43, 17);
            this.w4.TabIndex = 10;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Начальное состояние";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текущее состояние";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(183, 211);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(74, 35);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 290);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.txt_CurrentState);
            this.Controls.Add(this.txt_StartState);
            this.Controls.Add(this.btn_z4);
            this.Controls.Add(this.btn_z3);
            this.Controls.Add(this.btn_z2);
            this.Controls.Add(this.btn_z1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.CheckBox w1;
        private System.Windows.Forms.CheckBox w2;
        private System.Windows.Forms.CheckBox w3;
        private System.Windows.Forms.CheckBox w4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Reset;
    }
}

