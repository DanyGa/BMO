Imports System.Threading
Public Class frmPrincipal
    Dim _loop As Integer = 0
    Private Sub BtnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        _loop = 10
        bgwBarra.RunWorkerAsync()
    End Sub

    Private Sub BgwBarra_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwBarra.DoWork
        For x As Integer = 0 To _loop
            Thread.Sleep(1000)
            bgwBarra.ReportProgress(CInt((x / _loop) * 100))

        Next
    End Sub

    Private Sub BgwBarra_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwBarra.ProgressChanged
        Me.prgBarra.Value = e.ProgressPercentage
    End Sub

    Private Sub BgwBarra_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwBarra.RunWorkerCompleted
        frmMenu.Show()
        Me.Close()
    End Sub
End Class
