Public Class Form1
    Private Sub nameInput_TextChanged(sender As Object, e As EventArgs) Handles nameInput.TextChanged
        Dim userName As String = nameInput.Text
        Try
            If String.IsNullOrEmpty(userName) Then
                MessageBox.Show("User name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                nameInput.Focus() ' Set focus back to the TextBox
                Return ' Exit the current method or sub
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while processing the name input: " & ex.Message)
        End Try

    End Sub

    Private Sub commentBtn_TextChanged(sender As Object, e As EventArgs) Handles commentBtn.TextChanged
        Dim userComment As String = commentBtn.Text

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click

    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

    End Sub

    Private Sub userListField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userListField.SelectedIndexChanged

    End Sub
End Class
