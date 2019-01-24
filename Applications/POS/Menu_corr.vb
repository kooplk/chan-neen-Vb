Public Class frmcorrect

    Public price As Double = frmMain.price
    Public bread As String = ""
    Public fruit As String = ""
    Public Fruit_choose As Boolean = False
    Public Bread_choose As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bthExit.Click

        Me.Visible = False
        frmMain.price = price
        frmMain.Visible = True
    End Sub

    Private Sub bthAddrecord_Click(sender As Object, e As EventArgs) Handles bthAddrecord.Click 'Add record to the lstRecord
        radioBread_check()
        CHKBOXfruit_check()
        If Fruit_choose = False And bread = "" Then
            MessageBox.Show("Please Input need to correct the Record !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else : order()
            MessageBox.Show("Add Record Success ! ", "Alret", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset_Checked()
        End If

    End Sub

    Private Sub bthDelRecord_Click(sender As Object, e As EventArgs) Handles bthDelRecord.Click
        Dim words As String = Me.lstRecord.SelectedItem
        Me.lstRecord.Items.Remove(Me.lstRecord.SelectedItem)
        CUTfruit_check(words)
        CUTBread_check(words)
        MessageBox.Show("Delete Record Success ! ", "Alret", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Check Record 
    Sub radioBread_check() 'If items are checked then will add price 
        If radBreadA.Checked Then
            bread = "Grain Wheat -- HK$8.00"
            price = price + 8
            frmMain.CountGW = frmMain.CountGW + 1
        ElseIf radBreadB.Checked Then
            bread = "Honey Oat -- HK$10.50"
            price = price + 10.5
            frmMain.CountHO = frmMain.CountHO + 1
        Else
            bread = ""
        End If
    End Sub
    Sub AddfruitReco() 'Check Which Fruit Chosed  And Add items to Main_corr.lstrecord
        If ChkApple.Checked Then
            lstRecord.Items.Add("Apple -- HK$10.00")
            frmMain.CountApple = frmMain.CountApple + 1
        End If
        If ChkLettuce.Checked Then
            lstRecord.Items.Add("Lettuce -- HK$12.50")
            frmMain.CountLettue = frmMain.CountLettue + 1
        End If
        If ChkTomato.Checked Then
            lstRecord.Items.Add("Tomato -- HK$8.50")
            frmMain.CountTomato = frmMain.CountTomato + 1
        End If
        If ChkHam.Checked Then
             lstRecord.Items.Add("Ham -- HK$20.00")
            frmMain.CountHam = frmMain.CountHam + 1
        End If
        If ChkTuna.Checked Then
             lstRecord.Items.Add("Tuna -- HK$18.50")
            frmMain.CountTuna = frmMain.CountTuna + 1
        End If
    End Sub
    Sub CHKBOXfruit_check()
        If ChkApple.Checked Then
            Fruit_choose = True
            price = price + 10
        End If
        If ChkLettuce.Checked Then
            Fruit_choose = True
            price = price + 12.5
        End If
        If ChkTomato.Checked Then
            Fruit_choose = True
            price = price + 8.5
        End If
        If ChkHam.Checked Then
            Fruit_choose = True
            price = price + 20
        End If
        If ChkTuna.Checked Then
            Fruit_choose = True
            price = price + 18.5
        End If
    End Sub
    'End Of Check Record Moodle

    'Delete Record
    Sub CUTBread_check(ByRef words As String) 'If items are deleted on lstrecord  then will resurm the  price and del the items  
        If words = radBreadA.Text Then
            price = price - 8
            frmMain.CountGW = frmMain.CountGW - 1
        ElseIf words = radBreadB.Text Then
            price = price - 10.5
            frmMain.CountHO = frmMain.CountHO - 1

        End If
    End Sub

    Sub CUTfruit_check(ByRef words As String) 'If items are deleted on lstrecord  then will resurm the  price and del the items  
        If words = ChkApple.Text Then
            price = price - 10
            frmMain.CountApple = frmMain.CountApple - 1
        End If
        If words = ChkLettuce.Text Then
            price = price - 12.5
            frmMain.CountLettue = frmMain.CountLettue - 1
        End If
        If words = ChkTomato.Text Then
            price = price - 8.5
            frmMain.CountTomato = frmMain.CountTomato - 1
        End If
        If words = ChkHam.Text Then
            price = price - 20
            frmMain.CountHam = frmMain.CountHam - 1
        End If
        If words = ChkTuna.Text Then
            price = price - 18.5
            frmMain.CountTuna = frmMain.CountTuna - 1
        End If
    End Sub

    'End Of Delete Record Moodle

    'Add Record 
    Sub order() 'Add record to Menu_corr.vb the lstRecord
        If Fruit_choose = True Then
            AddfruitReco()
        End If
        If bread <> "" Then
            Me.lstRecord.Items.Add(bread)
        End If
    End Sub

    Sub Reset_Checked()
        ChkApple.Checked = False
        ChkLettuce.Checked = False
        ChkTomato.Checked = False
        ChkHam.Checked = False
        ChkTuna.Checked = False
        radBreadA.Checked = False
        radBreadB.Checked = False
    End Sub
    'ENd of Add Record Moodle

End Class
