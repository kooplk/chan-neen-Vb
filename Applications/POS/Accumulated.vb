Public Class FrmAccumlated

    Dim sum As Double
    Dim Max_price As Double
    Dim Min_price As Double
    Dim price As Double
    Dim MaxIndex As Integer = 0
    Dim MostPOP As String
    Dim MostPOP_index As Integer
    Dim tmp As Integer
    Public CountApple As Integer = frmMain.CountApple
    Public CountLettue As Integer = frmMain.CountLettue
    Public CountTomato As Integer = frmMain.CountTomato
    Public CountHam As Integer = frmMain.CountHam
    Public CountTuna As Integer = frmMain.CountTuna
    Public CountGW As Integer = frmMain.CountGW
    Public CountHO As Integer = frmMain.CountHO


    Private Sub BtnMPI_Click(sender As Object, e As EventArgs) Handles BtnMPI.Click
        MessageBox.Show("The Most Popular Itmes is " & MostPOP, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnBTHP_Click(sender As Object, e As EventArgs) Handles BtnBTHP.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub BtnCA_Click(sender As Object, e As EventArgs) Handles BtnCA.Click
        Dim result As DialogResult = MessageBox.Show("Are You sure To Clear Records ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            For a = 0 To frmMain.list.Count - 1
                frmMain.list(a) = 0
            Next
            frmMain.counter = 0
            sum = 0
            MessageBox.Show("Reset Value Sucessful", "Notic", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Refresh()
        End If

    End Sub

 
    Private Sub FrmAccumlated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxNumOfOrder.Text = CStr(frmMain.counter)

        For i = 0 To frmMain.list.Count - 1
            sum = sum + frmMain.list(i)

            If Max_price < frmMain.list(i) Then    ' Store the maximum value.
                Max_price = frmMain.list(i) ' Store the index of the maximum index.
                MaxIndex = i
            End If
        Next

        For index = 0 To frmMain.countVal.Count - 1 '+
            If tmp < frmMain.countVal(index) Then '+
                tmp = frmMain.countVal(index) '+
                MostPOP_index = index '+
            End If '+
        Next
        MostPOP = frmMain.items(MostPOP_index)
        TxtBoxTotalSales.Text = CStr(sum)
        txtAVG.Text = CStr(sum / frmMain.counter)
        txtMax.Text = CStr(Max_price)
    End Sub

    Private Sub txtMax_TextChanged(sender As Object, e As EventArgs) Handles txtMax.TextChanged

    End Sub
End Class