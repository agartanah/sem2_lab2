namespace sem2_lab2 {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.menuStrip3 = new System.Windows.Forms.MenuStrip();
      this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.labelCondition = new System.Windows.Forms.Label();
      this.textBoxA = new System.Windows.Forms.TextBox();
      this.textBoxB = new System.Windows.Forms.TextBox();
      this.textBoxE = new System.Windows.Forms.TextBox();
      this.найтиМинимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.panel1.SuspendLayout();
      this.menuStrip3.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Location = new System.Drawing.Point(0, 52);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1244, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // chart
      // 
      chartArea2.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea2);
      legend2.Enabled = false;
      legend2.Name = "Legend1";
      this.chart.Legends.Add(legend2);
      this.chart.Location = new System.Drawing.Point(599, 12);
      this.chart.Name = "chart";
      this.chart.RightToLeft = System.Windows.Forms.RightToLeft.No;
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.IsVisibleInLegend = false;
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart.Series.Add(series2);
      this.chart.Size = new System.Drawing.Size(592, 450);
      this.chart.TabIndex = 1;
      this.chart.Text = "chart1";
      // 
      // menuStrip2
      // 
      this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip2.Location = new System.Drawing.Point(0, 28);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(1244, 24);
      this.menuStrip2.TabIndex = 2;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(3, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 39);
      this.label1.TabIndex = 4;
      this.label1.Text = "f(x) = ";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Transparent;
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Location = new System.Drawing.Point(12, 55);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(506, 100);
      this.panel1.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(325, 2);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(24, 26);
      this.label6.TabIndex = 6;
      this.label6.Text = "2";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(105, 28);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(224, 39);
      this.label5.TabIndex = 5;
      this.label5.Text = "(27 - 18x + 2x";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(397, 21);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(74, 26);
      this.label8.TabIndex = 8;
      this.label8.Text = "-(x / 3)";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(335, 28);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(56, 39);
      this.label7.TabIndex = 7;
      this.label7.Text = ") e";
      // 
      // menuStrip3
      // 
      this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
      this.menuStrip3.Location = new System.Drawing.Point(0, 0);
      this.menuStrip3.Name = "menuStrip3";
      this.menuStrip3.Size = new System.Drawing.Size(1244, 28);
      this.menuStrip3.TabIndex = 7;
      this.menuStrip3.Text = "menuStrip3";
      // 
      // менюToolStripMenuItem
      // 
      this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьГрафикToolStripMenuItem,
            this.очиститьГрафикToolStripMenuItem,
            this.найтиМинимумToolStripMenuItem});
      this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
      this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
      this.менюToolStripMenuItem.Text = "Меню";
      // 
      // построитьГрафикToolStripMenuItem
      // 
      this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
      this.построитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.построитьГрафикToolStripMenuItem.Text = "Построить график";
      this.построитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
      // 
      // очиститьГрафикToolStripMenuItem
      // 
      this.очиститьГрафикToolStripMenuItem.Name = "очиститьГрафикToolStripMenuItem";
      this.очиститьГрафикToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.очиститьГрафикToolStripMenuItem.Text = "Очистить график";
      this.очиститьГрафикToolStripMenuItem.Click += new System.EventHandler(this.очиститьГрафикToolStripMenuItem_Click);
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip2.Name = "contextMenuStrip2";
      this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(52, 208);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 31);
      this.label2.TabIndex = 10;
      this.label2.Text = "a  = ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(52, 269);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 31);
      this.label3.TabIndex = 11;
      this.label3.Text = "b  = ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(52, 334);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 31);
      this.label4.TabIndex = 13;
      this.label4.Text = "e  = ";
      // 
      // labelCondition
      // 
      this.labelCondition.AutoSize = true;
      this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelCondition.Location = new System.Drawing.Point(17, 433);
      this.labelCondition.Name = "labelCondition";
      this.labelCondition.Size = new System.Drawing.Size(0, 29);
      this.labelCondition.TabIndex = 15;
      // 
      // textBoxA
      // 
      this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxA.Location = new System.Drawing.Point(124, 208);
      this.textBoxA.Name = "textBoxA";
      this.textBoxA.Size = new System.Drawing.Size(339, 36);
      this.textBoxA.TabIndex = 16;
      // 
      // textBoxB
      // 
      this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxB.Location = new System.Drawing.Point(124, 264);
      this.textBoxB.Name = "textBoxB";
      this.textBoxB.Size = new System.Drawing.Size(339, 36);
      this.textBoxB.TabIndex = 17;
      // 
      // textBoxE
      // 
      this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxE.Location = new System.Drawing.Point(124, 329);
      this.textBoxE.Name = "textBoxE";
      this.textBoxE.Size = new System.Drawing.Size(339, 36);
      this.textBoxE.TabIndex = 18;
      // 
      // найтиМинимумToolStripMenuItem
      // 
      this.найтиМинимумToolStripMenuItem.Name = "найтиМинимумToolStripMenuItem";
      this.найтиМинимумToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.найтиМинимумToolStripMenuItem.Text = "Найти минимум";
      this.найтиМинимумToolStripMenuItem.Click += new System.EventHandler(this.найтиМинимумToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1244, 685);
      this.Controls.Add(this.textBoxE);
      this.Controls.Add(this.textBoxB);
      this.Controls.Add(this.textBoxA);
      this.Controls.Add(this.labelCondition);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.chart);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.menuStrip2);
      this.Controls.Add(this.menuStrip3);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.menuStrip3.ResumeLayout(false);
      this.menuStrip3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.MenuStrip menuStrip3;
    private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьГрафикToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label labelCondition;
    private System.Windows.Forms.TextBox textBoxA;
    private System.Windows.Forms.TextBox textBoxB;
    private System.Windows.Forms.TextBox textBoxE;
    private System.Windows.Forms.ToolStripMenuItem найтиМинимумToolStripMenuItem;
  }
}

