<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcorrect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcorrect))
        Me.bthExit = New System.Windows.Forms.Button()
        Me.bthDelRecord = New System.Windows.Forms.Button()
        Me.lstRecord = New System.Windows.Forms.ListBox()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.bthAddrecord = New System.Windows.Forms.Button()
        Me.gpdrink = New System.Windows.Forms.GroupBox()
        Me.radBreadA = New System.Windows.Forms.RadioButton()
        Me.radBreadB = New System.Windows.Forms.RadioButton()
        Me.gpfood = New System.Windows.Forms.GroupBox()
        Me.ChkTuna = New System.Windows.Forms.CheckBox()
        Me.ChkHam = New System.Windows.Forms.CheckBox()
        Me.ChkTomato = New System.Windows.Forms.CheckBox()
        Me.ChkLettuce = New System.Windows.Forms.CheckBox()
        Me.ChkApple = New System.Windows.Forms.CheckBox()
        Me.gpdrink.SuspendLayout()
        Me.gpfood.SuspendLayout()
        Me.SuspendLayout()
        '
        'bthExit
        '
        Me.bthExit.Location = New System.Drawing.Point(421, 478)
        Me.bthExit.Name = "bthExit"
        Me.bthExit.Size = New System.Drawing.Size(109, 46)
        Me.bthExit.TabIndex = 0
        Me.bthExit.Text = "Back to Home Page"
        Me.bthExit.UseVisualStyleBackColor = True
        '
        'bthDelRecord
        '
        Me.bthDelRecord.Location = New System.Drawing.Point(249, 478)
        Me.bthDelRecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bthDelRecord.Name = "bthDelRecord"
        Me.bthDelRecord.Size = New System.Drawing.Size(109, 46)
        Me.bthDelRecord.TabIndex = 34
        Me.bthDelRecord.Text = "Delete Record"
        Me.bthDelRecord.UseVisualStyleBackColor = True
        '
        'lstRecord
        '
        Me.lstRecord.FormattingEnabled = True
        Me.lstRecord.ItemHeight = 15
        Me.lstRecord.Location = New System.Drawing.Point(155, 35)
        Me.lstRecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstRecord.Name = "lstRecord"
        Me.lstRecord.Size = New System.Drawing.Size(313, 424)
        Me.lstRecord.TabIndex = 35
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Location = New System.Drawing.Point(29, 35)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(111, 15)
        Me.lblRecord.TabIndex = 36
        Me.lblRecord.Text = "Customer History:"
        '
        'bthAddrecord
        '
        Me.bthAddrecord.Location = New System.Drawing.Point(96, 478)
        Me.bthAddrecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bthAddrecord.Name = "bthAddrecord"
        Me.bthAddrecord.Size = New System.Drawing.Size(112, 46)
        Me.bthAddrecord.TabIndex = 39
        Me.bthAddrecord.Text = "Append Record"
        Me.bthAddrecord.UseVisualStyleBackColor = True
        '
        'gpdrink
        '
        Me.gpdrink.Controls.Add(Me.radBreadA)
        Me.gpdrink.Controls.Add(Me.radBreadB)
        Me.gpdrink.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gpdrink.Location = New System.Drawing.Point(484, 249)
        Me.gpdrink.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpdrink.Name = "gpdrink"
        Me.gpdrink.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpdrink.Size = New System.Drawing.Size(221, 182)
        Me.gpdrink.TabIndex = 40
        Me.gpdrink.TabStop = False
        Me.gpdrink.Text = "Selection of Bread"
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
        'gpfood
        '
        Me.gpfood.Controls.Add(Me.ChkTuna)
        Me.gpfood.Controls.Add(Me.ChkHam)
        Me.gpfood.Controls.Add(Me.ChkTomato)
        Me.gpfood.Controls.Add(Me.ChkLettuce)
        Me.gpfood.Controls.Add(Me.ChkApple)
        Me.gpfood.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.gpfood.Location = New System.Drawing.Point(492, 35)
        Me.gpfood.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpfood.Name = "gpfood"
        Me.gpfood.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpfood.Size = New System.Drawing.Size(208, 182)
        Me.gpfood.TabIndex = 34
        Me.gpfood.TabStop = False
        Me.gpfood.Text = "Selection of Salad Ingredients"
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
        'frmcorrect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.POS.My.Resources.Resources._20140102101330375
        Me.ClientSize = New System.Drawing.Size(720, 537)
        Me.Controls.Add(Me.gpfood)
        Me.Controls.Add(Me.gpdrink)
        Me.Controls.Add(Me.bthAddrecord)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.lstRecord)
        Me.Controls.Add(Me.bthDelRecord)
        Me.Controls.Add(Me.bthExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcorrect"
        Me.Text = "Menu_corr"
        Me.gpdrink.ResumeLayout(False)
        Me.gpdrink.PerformLayout()
        Me.gpfood.ResumeLayout(False)
        Me.gpfood.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bthExit As System.Windows.Forms.Button
    Friend WithEvents bthDelRecord As System.Windows.Forms.Button
    Friend WithEvents lstRecord As System.Windows.Forms.ListBox
    Friend WithEvents lblRecord As System.Windows.Forms.Label
    Friend WithEvents bthAddrecord As System.Windows.Forms.Button
    Friend WithEvents gpdrink As System.Windows.Forms.GroupBox
    Friend WithEvents radBreadA As System.Windows.Forms.RadioButton
    Friend WithEvents radBreadB As System.Windows.Forms.RadioButton
    Friend WithEvents gpfood As System.Windows.Forms.GroupBox
    Friend WithEvents ChkTuna As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHam As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents ChkApple As System.Windows.Forms.CheckBox
End Class
