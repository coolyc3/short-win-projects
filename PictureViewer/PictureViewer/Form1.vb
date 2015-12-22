Public Class Form1
    Private Sub ShowButton_Click() Handles ShowButton.Click
        'Open a dialog to pick the pic, Then load the pic
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ClearButton_Click() Handles ClearButton.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub BackgroundButton_Click() Handles BackgroundButton.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub CloseButton_Click() Handles CloseButton.Click
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged() Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub
End Class
