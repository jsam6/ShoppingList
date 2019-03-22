Public Class Form1

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        checkListBox.Items.Add(itemInput.Text())
        itemInput.Clear()

    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        checkListBox.Items.Clear()

    End Sub


    Private Sub remBtn_Click(sender As Object, e As EventArgs) Handles remBtn.Click
        checkListBox.Items.Remove(checkListBox.SelectedItem)
    End Sub
End Class
