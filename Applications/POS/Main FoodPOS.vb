Public Class frmMain
    Public fruit As String = ""
    Public bread As String = ""
    Public Fruit_choose As Boolean = False
    Public Bread_choose As Boolean = False
    Public price As Double = 0
    Public list(99) As String '<---save price 
    'count click value'
    Public CountApple As Integer
    Public CountLettue As Integer
    Public CountTomato As Integer
    Public CountHam As Integer
    Public CountTuna As Integer
    Public CountGW As Integer
    Public CountHO As Integer
    Public countVal() As Integer '+
    'End '
    Public items() As String = {"Apple", "Lettue", "Tomato", "Ham", "Tuna", "Grain Wheat", "Honey Oat"} '+
    Public counter As Integer = 0
    Public i As Integer = 1

    ''' <remarks>Student_id :170037102 And 170229806''' </remarks>

    Private Sub bthCheckRecord_Click(sender As Object, e As EventArgs) Handles bthCheckRecord.Click 'Open the check form 

        If price = 0 Then
            MessageBox.Show("Please Choose the Fruit or Bread Thank You !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf counter < 99 Then
            counter += 1  'Increment counter by 1
            list(counter - 1) = price
            frmCheck.Show()
            Me.Visible = False
            countVal = {CountApple, CountLettue, CountTomato, CountHam, CountTuna, CountGW, CountHO} '+
        Else : MsgBox("No space to record." & "Please Clear The Record. ", "Warning", )
        End If


    End Sub

    Private Sub bthCorrectRecord_Click(sender As Object, e As EventArgs) Handles bthCorrectRecord.Click 'open the correct form 
        frmcorrect.Show()
        Me.Visible = False
        frmcorrect.price = price
    End Sub

    Private Sub bthAddrecord_Click(sender As Object, e As EventArgs) Handles bthAddrecord.Click 'Add Customer name to the Main Food POS the lstRecord ....
        CHKBOXfruit_check()
        radioBread_check()
        Dim a As Integer = txtquantity.Text
        Addrecord(a)
    End Sub

    Private Sub BtnAccum_Click(sender As Object, e As EventArgs) Handles BtnAccum.Click
        FrmAccumlated.Show()
    End Sub

    ''Moodle of AddRecord 
    Sub Addrecord(ByVal a As Integer)
        If a <= 0 Or Trim(TextCus.Text) = "" Then
            MessageBox.Show("Please Put Down Correct Quantity Or Write Down the customer's name !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CUTBread_check() 'undo 
            CUTfruit_check() 'undo 
        ElseIf Fruit_choose = False And Bread_choose = False Then
            MessageBox.Show("Please Choose the Fruit or Bread Thank You !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lstRecord.Items.Add(TextCus.Text)
            order(a)
            Reset_Checked()
            bthCheckRecord.Focus()
            txtquantity.Text = 1
            TextCus.ReadOnly = True
        End If

    End Sub

    Sub AddfruitReco() 'Check Which Fruit Chosed  And Add items to Main_corr.lstrecord
        If ChkApple.Checked Then
            fruit = "Apple -- HK$10.00"
            frmcorrect.lstRecord.Items.Add("Apple -- HK$10.00")
            CountApple = CountApple + 1
        End If
        If ChkLettuce.Checked Then
            fruit = fruit & "Lettuce -- HK$12.50"
            frmcorrect.lstRecord.Items.Add("Lettuce -- HK$12.50")
            CountLettue = CountLettue + 1
        End If
        If ChkTomato.Checked Then
            fruit = fruit & "Tomato -- HK$8.50"
            frmcorrect.lstRecord.Items.Add("Tomato -- HK$8.50")
            CountTomato = CountTomato + 1
        End If
        If ChkHam.Checked Then
            fruit = fruit & "Ham -- HK$20.00"
            frmcorrect.lstRecord.Items.Add("Ham -- HK$20.00")
            CountHam = CountHam + 1
        End If
        If ChkTuna.Checked Then
            fruit = fruit & "Tuna -- HK$18.50"
            frmcorrect.lstRecord.Items.Add("Tuna -- HK$18.50")
            CountTuna = CountTuna + 1
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

    Sub radioBread_check()
        If radBreadA.Checked Then
            bread = "Grain Wheat -- HK$8.00"
            price = price + 8
            Bread_choose = True
            CountGW = CountGW + 1
        ElseIf radBreadB.Checked Then
            bread = "Honey Oat --- HK$10.50"
            price = price + 10.5
            Bread_choose = True
            CountHO = CountHO + 1
        Else
            Bread_choose = False
        End If
    End Sub

    Sub order(ByRef a As Integer) 'Add record to Menu_corr.vb the lstRecord
        frmcorrect.lstRecord.Items.Add(Me.TextCus.Text)
        For b = 1 To a
            If Fruit_choose = True Then
                AddfruitReco()
            End If

            If Bread_choose = True Then
                frmcorrect.lstRecord.Items.Add(bread)
            End If

        Next
        price = price * a

    End Sub


    Sub Reset_Checked() 'Reset the choose 
        ChkApple.Checked = False
        ChkLettuce.Checked = False
        ChkTomato.Checked = False
        ChkHam.Checked = False
        ChkTuna.Checked = False
        radBreadA.Checked = False
        radBreadB.Checked = False
        TextCus.Text = ""
        Fruit_choose = False
        Bread_choose = False
    End Sub

    ''End of Addcord Moodle 

    ''Undo Moodle 
    Sub CUTfruit_check() 'If items are deleted on lstrecord  then will resurm the  price and del the items  
        If ChkApple.Checked Then
            price = price - 10
            CountApple = CountApple - 1
            frmcorrect.lstRecord.Items.Remove("Apple -- HK$10.00")
        End If
        If ChkLettuce.Checked Then
            price = price - 12.5
            CountLettue = CountLettue - 1
            frmcorrect.lstRecord.Items.Remove("Lettuce -- HK$12.50")
        End If
        If ChkTomato.Checked Then
            price = price - 8.5
            CountTomato = CountTomato - 1
            frmcorrect.lstRecord.Items.Remove("Tomato -- HK$8.50")
        End If
        If ChkHam.Checked Then
            price = price - 20
            CountHam = CountHam - 1
            frmcorrect.lstRecord.Items.Remove("Ham -- HK$20.00")
        End If
        If ChkTuna.Checked Then
            price = price - 18.5
            frmcorrect.lstRecord.Items.Remove("Tuna -- HK$18.50")
            CountTuna = CountTuna - 1
        End If
    End Sub
    Sub CUTBread_check() 'If items are deleted on lstrecord  then will resurm the  price and del the items  
        If radBreadA.Checked Then
            price = price - 8
        ElseIf radBreadB.Checked Then
            price = price - 10.5

        End If
    End Sub

    ''End Undo Moodle

    ''Quantity for order
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtquantity.Text = i
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddqu.Click
        i += 1
        txtquantity.Text = i
    End Sub

    Private Sub btncut_Click(sender As Object, e As EventArgs) Handles btncutqu.Click
        i -= 1
        txtquantity.Text = i
    End Sub

    '' End of Quantity Moodle

    Private Sub TextCus_TextChanged(sender As Object, e As EventArgs) Handles TextCus.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            CHKBOXfruit_check()
            radioBread_check()
            Dim a As Integer = txtquantity.Text
            Addrecord(a)
        End If
    End Sub

    'Found words moodle 
    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        find_word()
    End Sub

    Private Sub TextFind_TextChanged(sender As Object, e As EventArgs) Handles TextFind.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            find_word()
        End If
    End Sub

    Sub find_word()
        Dim Found As Boolean = False
        Dim find_words As String = TextFind.Text
        Dim words As String
        If find_words = "" Then
            MessageBox.Show("Please write the Customer's Name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            For index As Integer = 0 To lstRecord.Items.Count - 1
                words = lstRecord.Items(index)
                If words.ToLower = find_words.ToLower Then
                    Found = True
                    MsgBox(find_words & " is on line " & (index + 1) & " of the list.", , )
                End If
            Next
            If Found = False Then
                MessageBox.Show("Customer not Found  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub
    ''End found words Moodle

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles bthExit.Click 'Exit the POS
        Me.Close()
    End Sub

End Class
