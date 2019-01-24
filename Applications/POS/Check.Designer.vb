<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheck))
        Me.gpcheck = New System.Windows.Forms.GroupBox()
        Me.txtReceived = New System.Windows.Forms.TextBox()
        Me.lblpay = New System.Windows.Forms.Label()
        Me.lblRealGet = New System.Windows.Forms.Label()
        Me.txtRealGet = New System.Windows.Forms.TextBox()
        Me.txtTotleValue = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.gpPayment = New System.Windows.Forms.GroupBox()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.radOctopus = New System.Windows.Forms.RadioButton()
        Me.radCreditCard = New System.Windows.Forms.RadioButton()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.gpcheck.SuspendLayout()
        Me.gpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpcheck
        '
        Me.gpcheck.Controls.Add(Me.txtReceived)
        Me.gpcheck.Controls.Add(Me.lblpay)
        Me.gpcheck.Controls.Add(Me.lblRealGet)
        Me.gpcheck.Controls.Add(Me.txtRealGet)
        Me.gpcheck.Controls.Add(Me.txtTotleValue)
        Me.gpcheck.Controls.Add(Me.lbltotal)
        Me.gpcheck.Location = New System.Drawing.Point(288, 43)
        Me.gpcheck.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpcheck.Name = "gpcheck"
        Me.gpcheck.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gpcheck.Size = New System.Drawing.Size(285, 159)
        Me.gpcheck.TabIndex = 35
        Me.gpcheck.TabStop = False
        Me.gpcheck.Text = "Count"
        '
        'txtReceived
        '
        Me.txtReceived.Location = New System.Drawing.Point(145, 117)
        Me.txtReceived.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.ReadOnly = True
        Me.txtReceived.Size = New System.Drawing.Size(132, 25)
        Me.txtReceived.TabIndex = 40
        '
        'lblpay
        '
        Me.lblpay.AutoSize = True
        Me.lblpay.Location = New System.Drawing.Point(8, 120)
        Me.lblpay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpay.Name = "lblpay"
        Me.lblpay.Size = New System.Drawing.Size(62, 15)
        Me.lblpay.TabIndex = 39
        Me.lblpay.Text = "Received:"
        '
        'lblRealGet
        '
        Me.lblRealGet.AutoSize = True
        Me.lblRealGet.Location = New System.Drawing.Point(8, 65)
        Me.lblRealGet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRealGet.Name = "lblRealGet"
        Me.lblRealGet.Size = New System.Drawing.Size(119, 15)
        Me.lblRealGet.TabIndex = 38
        Me.lblRealGet.Text = "Deducted discount :"
        '
        'txtRealGet
        '
        Me.txtRealGet.Location = New System.Drawing.Point(145, 62)
        Me.txtRealGet.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRealGet.Name = "txtRealGet"
        Me.txtRealGet.ReadOnly = True
        Me.txtRealGet.Size = New System.Drawing.Size(132, 25)
        Me.txtRealGet.TabIndex = 37
        '
        'txtTotleValue
        '
        Me.txtTotleValue.Location = New System.Drawing.Point(145, 23)
        Me.txtTotleValue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTotleValue.Name = "txtTotleValue"
        Me.txtTotleValue.ReadOnly = True
        Me.txtTotleValue.Size = New System.Drawing.Size(132, 25)
        Me.txtTotleValue.TabIndex = 36
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(8, 33)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(41, 15)
        Me.lbltotal.TabIndex = 35
        Me.lbltotal.Text = "Total:"
        '
        'gpPayment
        '
        Me.gpPayment.Controls.Add(Me.radCash)
        Me.gpPayment.Controls.Add(Me.radOctopus)
        Me.gpPayment.Controls.Add(Me.radCreditCard)
        Me.gpPayment.Location = New System.Drawing.Point(40, 43)
        Me.gpPayment.Name = "gpPayment"
        Me.gpPayment.Size = New System.Drawing.Size(227, 159)
        Me.gpPayment.TabIndex = 36
        Me.gpPayment.TabStop = False
        Me.gpPayment.Text = "Payment"
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(5, 120)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(55, 19)
        Me.radCash.TabIndex = 2
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'radOctopus
        '
        Me.radOctopus.AutoSize = True
        Me.radOctopus.Location = New System.Drawing.Point(5, 78)
        Me.radOctopus.Name = "radOctopus"
        Me.radOctopus.Size = New System.Drawing.Size(74, 19)
        Me.radOctopus.TabIndex = 1
        Me.radOctopus.TabStop = True
        Me.radOctopus.Text = "Octopus"
        Me.radOctopus.UseVisualStyleBackColor = True
        '
        'radCreditCard
        '
        Me.radCreditCard.AutoSize = True
        Me.radCreditCard.Location = New System.Drawing.Point(5, 33)
        Me.radCreditCard.Name = "radCreditCard"
        Me.radCreditCard.Size = New System.Drawing.Size(195, 19)
        Me.radCreditCard.TabIndex = 0
        Me.radCreditCard.TabStop = True
        Me.radCreditCard.Text = "VISA/MasterCard/Union Pay"
        Me.radCreditCard.UseVisualStyleBackColor = True
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Location = New System.Drawing.Point(21, 9)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(60, 15)
        Me.lblCheck.TabIndex = 37
        Me.lblCheck.Text = "Checkout"
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(199, 244)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(159, 63)
        Me.btnPay.TabIndex = 38
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'frmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.POS.My.Resources.Resources.l2
        Me.ClientSize = New System.Drawing.Size(607, 342)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.gpPayment)
        Me.Controls.Add(Me.gpcheck)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCheck"
        Me.Text = "Checkout"
        Me.gpcheck.ResumeLayout(False)
        Me.gpcheck.PerformLayout()
        Me.gpPayment.ResumeLayout(False)
        Me.gpPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpcheck As System.Windows.Forms.GroupBox
    Friend WithEvents txtReceived As System.Windows.Forms.TextBox
    Friend WithEvents lblpay As System.Windows.Forms.Label
    Friend WithEvents txtTotleValue As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents gpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents radCash As System.Windows.Forms.RadioButton
    Friend WithEvents radOctopus As System.Windows.Forms.RadioButton
    Friend WithEvents radCreditCard As System.Windows.Forms.RadioButton
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents lblRealGet As System.Windows.Forms.Label
    Friend WithEvents txtRealGet As System.Windows.Forms.TextBox
End Class
