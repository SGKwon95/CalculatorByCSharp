namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.divine = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(387, 25);
            this.textBox1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 38);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(91, 175);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(152, 38);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.operatorButtonClicked);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(92, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 38);
            this.button8.TabIndex = 1;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(91, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(171, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 38);
            this.button9.TabIndex = 1;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(170, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 38);
            this.button6.TabIndex = 1;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(13, 175);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(73, 38);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // divine
            // 
            this.divine.Location = new System.Drawing.Point(250, 44);
            this.divine.Name = "divine";
            this.divine.Size = new System.Drawing.Size(73, 38);
            this.divine.TabIndex = 1;
            this.divine.Text = "/";
            this.divine.UseVisualStyleBackColor = true;
            this.divine.Click += new System.EventHandler(this.operatorButtonClicked);
            // 
            // multiple
            // 
            this.multiple.Location = new System.Drawing.Point(249, 88);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(73, 38);
            this.multiple.TabIndex = 1;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.operatorButtonClicked);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(249, 132);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(73, 38);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operatorButtonClicked);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(249, 176);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(73, 38);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operatorButtonClicked);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(328, 45);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(73, 38);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.specialButtonClicked);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(327, 89);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(73, 38);
            this.root.TabIndex = 1;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.specialButtonClicked);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(327, 133);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(73, 38);
            this.percent.TabIndex = 1;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.specialButtonClicked);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(327, 177);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(73, 38);
            this.point.TabIndex = 1;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.numButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 225);
            this.Controls.Add(this.point);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.root);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divine);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button divine;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button point;
    }
}

