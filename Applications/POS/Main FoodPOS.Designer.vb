<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gpSSI = New System.Windows.Forms.GroupBox()
        Me.ChkTuna = New System.Windows.Forms.CheckBox()
        Me.ChkHam = New System.Windows.Forms.CheckBox()
        Me.ChkTomato = New System.Windows.Forms.CheckBox()
        Me.ChkLettuce = New System.Windows.Forms.CheckBox()
        Me.ChkApple = New System.Windows.Forms.CheckBox()
        Me.lstRecord = New System.Windows.Forms.ListBox()
        Me.bthExit = New System.Windows.Forms.Button()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.LabOrderRec = New System.Windows.Forms.Label()
        Me.bthAddrecord = New System.Windows.Forms.Button()
        Me.bthCheckRecord = New System.Windows.Forms.Button()
        Me.bthCorrectRecord = New System.Windows.Forms.Button()
        Me.gpdiscount = New System.Windows.Forms.GroupBox()
        Me.RTBDiscount = New System.Windows.Forms.RichTextBox()
        Me.RTBTips = New System.Windows.Forms.RichTextBox()
        Me.lblTips = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.btnAddqu = New System.Windows.Forms.Button()
        Me.btncutqu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gpSOB = New System.Windows.Forms.GroupBox()
        Me.radBreadA = New System.Windows.Forms.RadioButton()
        Me.radBreadB = New System.Windows.Forms.RadioButton()
        Me.labCus1 = New System.Windows.Forms.Label()
        Me.TextCus = New System.Windows.Forms.TextBox()
        Me.TextFind = New System.Windows.Forms.TextBox()
        Me.LabFindCus2 = New System.Windows.Forms.Label()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.BtnAccum = New System.Windows.Forms.Button()
        Me.POSDataBase = New System.Windows.Forms.BindingSource(Me.components)
        Me.gpSSI.SuspendLayout()
        Me.gpdiscount.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpSOB.SuspendLayout()
        CType(Me.POSDataBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpSSI
        '
        Me.gpSSI.Controls.Add(Me.ChkTuna)
        Me.gpSSI.Controls.Add(Me.ChkHam)
        Me.gpSSI.Controls.Add(Me.ChkTomato)
        Me.gpSSI.Controls.Add(Me.ChkLettuce)
        Me.gpSSI.Controls.Add(Me.ChkApple)
        Me.gpSSI.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gpSSI.Location = New System.Drawing.Point(16, 51)
        Me.gpSSI.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpSSI.Name = "gpSSI"
        Me.gpSSI.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpSSI.Size = New System.Drawing.Size(208, 182)
        Me.gpSSI.TabIndex = 4
        Me.gpSSI.TabStop = False
        Me.gpSSI.Text = "Selection of Salad Ingredients"
        '
        'ChkTuna
        '
        Me.ChkTuna.AutoSize = True
        Me.ChkTuna.Location = New System.Drawing.Point(7, 153)
        Me.ChkTuna.Name = "ChkTuna"
        Me.ChkTuna.Size = New System.Drawing.Size(153, 23)
        Me.ChkTuna.TabIndex = 4
        Me.ChkTuna.Text = "Tuna -- HK$18.50"
        Me.ChkTuna.UseVisualStyleBackColor = True
        '
        'ChkHam
        '
        Me.ChkHam.AutoSize = True
        Me.ChkHam.Location = New System.Drawing.Point(7, 125)
        Me.ChkHam.Name = "ChkHam"
        Me.ChkHam.Size = New System.Drawing.Size(152, 23)
        Me.ChkHam.TabIndex = 3
        Me.ChkHam.Text = "Ham -- HK$20.00"
        Me.ChkHam.UseVisualStyleBackColor = True
        '
        'ChkTomato
        '
        Me.ChkTomato.AutoSize = True
        Me.ChkTomato.Location = New System.Drawing.Point(7, 96)
        Me.ChkTomato.Name = "ChkTomato"
        Me.ChkTomato.Size = New System.Drawing.Size(163, 23)
        Me.ChkTomato.TabIndex = 2
        Me.ChkTomato.Text = "Tomato -- HK$8.50"
        Me.ChkTomato.UseVisualStyleBackColor = True
        '
        'ChkLettuce
        '
        Me.ChkLettuce.AutoSize = True
        Me.ChkLettuce.Location = New System.Drawing.Point(7, 63)
        Me.ChkLettuce.Name = "ChkLettuce"
        Me.ChkLettuce.Size = New System.Drawing.Size(169, 23)
        Me.ChkLettuce.TabIndex = 1
        Me.ChkLettuce.Text = "Lettuce -- HK$12.50"
        Me.ChkLettuce.UseVisualStyleBackColor = True
        '
        'ChkApple
        '
        Me.ChkApple.AutoSize = True
        Me.ChkApple.Location = New System.Drawing.Point(7, 35)
        Me.ChkApple.Name = "ChkApple"
        Me.ChkApple.Size = New System.Drawing.Size(138, 23)
        Me.ChkApple.TabIndex = 0
        Me.ChkApple.Text = "Apple -- HK$10"
        Me.ChkApple.UseVisualStyleBackColor = True
        '
        'lstRecord
        '
        Me.lstRecord.FormattingEnabled = True
        Me.lstRecord.ItemHeight = 15
        Me.lstRecord.Location = New System.Drawing.Point(691, 43)
        Me.lstRecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstRecord.Name = "lstRecord"
        Me.lstRecord.Size = New System.Drawing.Size(221, 229)
        Me.lstRecord.TabIndex = 6
        '
        'bthExit
        '
        Me.bthExit.Location = New System.Drawing.Point(1193, 9)
        Me.bthExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bthExit.Name = "bthExit"
        Me.bthExit.Size = New System.Drawing.Size(157, 52)
        Me.bthExit.TabIndex = 23
        Me.bthExit.Text = "Exit"
        Me.bthExit.UseVisualStyleBackColor = True
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Location = New System.Drawing.Point(489, 53)
        Me.lblquantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(60, 15)
        Me.lblquantity.TabIndex = 29
        Me.lblquantity.Text = "Quantity:"
        '
        'LabOrderRec
        '
        Me.LabOrderRec.AutoSize = True
        Me.LabOrderRec.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabOrderRec.Location = New System.Drawing.Point(687, 14)
        Me.LabOrderRec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabOrderRec.Name = "LabOrderRec"
        Me.LabOrderRec.Size = New System.Drawing.Size(134, 19)
        Me.LabOrderRec.TabIndex = 31
        Me.LabOrderRec.Text = "Customer History:"
        '
        'bthAddrecord
        '
        Me.bthAddrecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthAddrecord.Location = New System.Drawing.Point(921, 43)
        Me.bthAddrecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bthAddrecord.Name = "bthAddrecord"
        Me.bthAddrecord.Size = New System.Drawing.Size(112, 46)
        Me.bthAddrecord.TabIndex = 32
        Me.bthAddrecord.Text = "Append Redcord"
        Me.bthAddrecord.UseVisualStyleBackColor = True
        '
        'bthCheckRecord
        '
        Me.bthCheckRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthCheckRecord.Location = New System.Drawing.Point(921, 225)
        Me.bthCheckRecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bthCheckRecord.Name = "bthCheckRecord"
        Me.bthCheckRecord.Size = New System.Drawing.Size(112, 46)
        Me.bthCheckRecord.TabIndex = 35
        Me.bthCheckRecord.Text = "Check"
        Me.bthCheckRecord.UseVisualStyleBackColor = True
        '
        'bthCorrectRecord
        '
        Me.bthCorrectRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthCorrectRecord.Location = New System.Drawing.Point(921, 99)
        Me.bthCorrectRecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bthCorrectRecord.Name = "bthCorrectRecord"
        Me.bthCorrectRecord.Size = New System.Drawing.Size(112, 46)
        Me.bthCorrectRecord.TabIndex = 36
        Me.bthCorrectRecord.Text = "Correct Record"
        Me.bthCorrectRecord.UseVisualStyleBackColor = True
        '
        'gpdiscount
        '
        Me.gpdiscount.Controls.Add(Me.RTBDiscount)
        Me.gpdiscount.Location = New System.Drawing.Point(1049, 83)
        Me.gpdiscount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpdiscount.Name = "gpdiscount"
        Me.gpdiscount.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpdiscount.Size = New System.Drawing.Size(305, 143)
        Me.gpdiscount.TabIndex = 37
        Me.gpdiscount.TabStop = False
        Me.gpdiscount.Text = "Discount"
        '
        'RTBDiscount
        '
        Me.RTBDiscount.BackColor = System.Drawing.Color.Yellow
        Me.RTBDiscount.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RTBDiscount.Location = New System.Drawing.Point(4, 24)
        Me.RTBDiscount.Name = "RTBDiscount"
        Me.RTBDiscount.ReadOnly = True
        Me.RTBDiscount.Size = New System.Drawing.Size(293, 111)
        Me.RTBDiscount.TabIndex = 0
        Me.RTBDiscount.Text = "Discount Offered per Order" & Global.Microsoft.VisualBasic.ChrW(10) & "10.00% discount if order amount >=$100.00"
        '
        'RTBTips
        '
        Me.RTBTips.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RTBTips.ForeColor = System.Drawing.Color.Red
        Me.RTBTips.Location = New System.Drawing.Point(1044, 256)
        Me.RTBTips.Name = "RTBTips"
        Me.RTBTips.ReadOnly = True
        Me.RTBTips.Size = New System.Drawing.Size(305, 140)
        Me.RTBTips.TabIndex = 38
        Me.RTBTips.Text = "1. When have the guest to come in , Say Welcome" & Global.Microsoft.VisualBasic.ChrW(10) & "2.Repeat the GUEST'S Order" & Global.Microsoft.VisualBasic.ChrW(10) & "3.Than" & _
    "k you for saying to the guest" & Global.Microsoft.VisualBasic.ChrW(10) & "4.If you encounter unreasonable guests, please see" & _
    "k manager"
        '
        'lblTips
        '
        Me.lblTips.AutoSize = True
        Me.lblTips.Location = New System.Drawing.Point(1045, 230)
        Me.lblTips.Name = "lblTips"
        Me.lblTips.Size = New System.Drawing.Size(41, 15)
        Me.lblTips.TabIndex = 39
        Me.lblTips.Text = "Hints:"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(495, 97)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(59, 25)
        Me.txtquantity.TabIndex = 41
        Me.txtquantity.Text = "1"
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAddqu
        '
        Me.btnAddqu.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddqu.Location = New System.Drawing.Point(561, 85)
        Me.btnAddqu.Name = "btnAddqu"
        Me.btnAddqu.Size = New System.Drawing.Size(59, 47)
        Me.btnAddqu.TabIndex = 42
        Me.btnAddqu.Text = "+"
        Me.btnAddqu.UseVisualStyleBackColor = True
        '
        'btncutqu
        '
        Me.btncutqu.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncutqu.Location = New System.Drawing.Point(625, 85)
        Me.btncutqu.Name = "btncutqu"
        Me.btncutqu.Size = New System.Drawing.Size(59, 47)
        Me.btncutqu.TabIndex = 43
        Me.btncutqu.Text = "-"
        Me.btncutqu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gpSOB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 215)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Order Information"
        '
        'gpSOB
        '
        Me.gpSOB.Controls.Add(Me.radBreadA)
        Me.gpSOB.Controls.Add(Me.radBreadB)
        Me.gpSOB.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gpSOB.Location = New System.Drawing.Point(220, 25)
        Me.gpSOB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpSOB.Name = "gpSOB"
        Me.gpSOB.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpSOB.Size = New System.Drawing.Size(221, 182)
        Me.gpSOB.TabIndex = 49
        Me.gpSOB.TabStop = False
        Me.gpSOB.Text = "Selection of Bread"
        '
        'radBreadA
        '
        Me.radBreadA.AutoSize = True
        Me.radBreadA.Location = New System.Drawing.Point(8, 55)
        Me.radBreadA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radBreadA.Name = "radBreadA"
        Me.radBreadA.Size = New System.Drawing.Size(196, 23)
        Me.radBreadA.TabIndex = 32
        Me.radBreadA.Text = "Grain Wheat -- HK$8.00"
        Me.radBreadA.UseVisualStyleBackColor = True
        '
        'radBreadB
        '
        Me.radBreadB.AutoSize = True
        Me.radBreadB.Location = New System.Drawing.Point(8, 99)
        Me.radBreadB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radBreadB.Name = "radBreadB"
        Me.radBreadB.Size = New System.Drawing.Size(192, 23)
        Me.radBreadB.TabIndex = 33
        Me.radBreadB.Text = "Honey Oat -- HK$10.50"
        Me.radBreadB.UseVisualStyleBackColor = True
        '
        'labCus1
        '
        Me.labCus1.AutoSize = True
        Me.labCus1.Location = New System.Drawing.Point(489, 157)
        Me.labCus1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCus1.Name = "labCus1"
        Me.labCus1.Size = New System.Drawing.Size(95, 15)
        Me.labCus1.TabIndex = 44
        Me.labCus1.Text = "Customer name"
        '
        'TextCus
        '
        Me.TextCus.Location = New System.Drawing.Point(493, 185)
        Me.TextCus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextCus.Name = "TextCus"
        Me.TextCus.Size = New System.Drawing.Size(177, 25)
        Me.TextCus.TabIndex = 45
        '
        'TextFind
        '
        Me.TextFind.Location = New System.Drawing.Point(687, 294)
        Me.TextFind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextFind.Name = "TextFind"
        Me.TextFind.Size = New System.Drawing.Size(157, 25)
        Me.TextFind.TabIndex = 46
        '
        'LabFindCus2
        '
        Me.LabFindCus2.AutoSize = True
        Me.LabFindCus2.Location = New System.Drawing.Point(687, 276)
        Me.LabFindCus2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabFindCus2.Name = "LabFindCus2"
        Me.LabFindCus2.Size = New System.Drawing.Size(125, 15)
        Me.LabFindCus2.TabIndex = 47
        Me.LabFindCus2.Text = "Find Customer name"
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(853, 294)
        Me.BtnFind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(64, 27)
        Me.BtnFind.TabIndex = 48
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'BtnAccum
        '
        Me.BtnAccum.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnAccum.Location = New System.Drawing.Point(921, 162)
        Me.BtnAccum.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAccum.Name = "BtnAccum"
        Me.BtnAccum.Size = New System.Drawing.Size(112, 46)
        Me.BtnAccum.TabIndex = 49
        Me.BtnAccum.Text = "Accumulated"
        Me.BtnAccum.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.POS.My.Resources.Resources._20140102101330375
        Me.ClientSize = New System.Drawing.Size(1363, 408)
        Me.Controls.Add(Me.BtnAccum)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.LabFindCus2)
        Me.Controls.Add(Me.TextFind)
        Me.Controls.Add(Me.TextCus)
        Me.Controls.Add(Me.labCus1)
        Me.Controls.Add(Me.btncutqu)
        Me.Controls.Add(Me.btnAddqu)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.lblTips)
        Me.Controls.Add(Me.RTBTips)
        Me.Controls.Add(Me.gpdiscount)
        Me.Controls.Add(Me.bthCorrectRecord)
        Me.Controls.Add(Me.bthCheckRecord)
        Me.Controls.Add(Me.bthAddrecord)
        Me.Controls.Add(Me.LabOrderRec)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.bthExit)
        Me.Controls.Add(Me.lstRecord)
        Me.Controls.Add(Me.gpSSI)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.Text = "My Cafe"
        Me.gpSSI.ResumeLayout(False)
        Me.gpSSI.PerformLayout()
        Me.gpdiscount.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gpSOB.ResumeLayout(False)
        Me.gpSOB.PerformLayout()
        CType(Me.POSDataBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpSSI As System.Windows.Forms.GroupBox
    Friend WithEvents bthExit As System.Windows.Forms.Button
    Friend WithEvents lblquantity As System.Windows.Forms.Label
    Friend WithEvents LabOrderRec As System.Windows.Forms.Label
    Friend WithEvents bthAddrecord As System.Windows.Forms.Button
    Friend WithEvents bthCheckRecord As System.Windows.Forms.Button
    Friend WithEvents bthCorrectRecord As System.Windows.Forms.Button
    Friend WithEvents gpdiscount As System.Windows.Forms.GroupBox
    Friend WithEvents RTBDiscount As System.Windows.Forms.RichTextBox
    Friend WithEvents lblTips As System.Windows.Forms.Label
    Private WithEvents RTBTips As System.Windows.Forms.RichTextBox
    Public WithEvents lstRecord As System.Windows.Forms.ListBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents btnAddqu As System.Windows.Forms.Button
    Friend WithEvents btncutqu As System.Windows.Forms.Button
    Friend WithEvents ChkTuna As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHam As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents ChkApple As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labCus1 As System.Windows.Forms.Label
    Friend WithEvents TextCus As System.Windows.Forms.TextBox
    Friend WithEvents TextFind As System.Windows.Forms.TextBox
    Friend WithEvents LabFindCus2 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents gpSOB As System.Windows.Forms.GroupBox
    Friend WithEvents radBreadA As System.Windows.Forms.RadioButton
    Friend WithEvents radBreadB As System.Windows.Forms.RadioButton
    Friend WithEvents BtnAccum As System.Windows.Forms.Button
    Friend WithEvents POSDataBase As System.Windows.Forms.BindingSource

End Class
