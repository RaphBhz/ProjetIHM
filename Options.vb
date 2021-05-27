Public Class Options
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_TimerMin = Int(Memory.getTimeMax() / 60)
        txt_TimerSec = Int(Memory.getTimeMax() Mod 60)
    End Sub
End Class