Public Class frmCheck

    Public charge As Double
    Public pay As Double
    Public price As Double = frmMain.price

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Check()
    End Sub
    Private Sub txtReceived_TextChanged(sender As Object, e As EventArgs) Handles txtReceived.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            Check()
        End If
    End Sub

    Private Sub bthExit_Click(sender As Object, e As EventArgs)
        frmMain.Visible = True
    End Sub

    Private Sub radCash_CheckedChanged(sender As Object, e As EventArgs) Handles radCash.CheckedChanged
        If radCash.Checked = True Then
            txtReceived.ReadOnly = False
            txtReceived.Focus()
        Else : txtReceived.ReadOnly = True

        End If
    End Sub

    Private Sub frmCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotleValue.Text = CStr(price)
        If price >= 100 Then
            price *= 0.9
            txtRealGet.Text = CStr(Math.Round(price, 2))
        Else
            txtRealGet.Text = CStr(price)
        End If
    End Sub

    Sub FIN()
        frmcorrect.lstRecord.Items.Clear()
        MessageBox.Show("Transection complete." & "Please Charge: " & charge, "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Sub Reset_Checked()
        radCash.Checked = False
        radCreditCard.Checked = False
        radOctopus.Checked = False


        frmMain.TextCus.ReadOnly = False
        Me.Close()
        frmMain.price = 0
        frmMain.i = 1
        frmMain.Show()
    End Sub

    Sub Check()
        If radCreditCard.Checked = False And radOctopus.Checked = False And radCash.Checked = False Then
            MessageBox.Show("Please Choose Thepayment Type ! ThankYou", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf radCreditCard.Checked = True Or radOctopus.Checked = True Then
            txtReceived.Text = txtRealGet.Text
            charge = 0
            FIN()
            Reset_Checked()
        ElseIf Not (IsNumeric(txtReceived.Text)) Then
            MessageBox.Show("Please write the correct value ! ThankYou", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf radCash.Checked = True And IsNumeric(txtReceived.Text) Then     'choose cash 
            pay = CDbl(txtReceived.Text)
            If pay >= price Then
                charge = pay - price
                FIN()
                Reset_Checked()
            Else
                MessageBox.Show("Please Choose Thepayment Type ! ThankYou", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtReceived.Focus()
            End If
        End If

    End Sub

End Class