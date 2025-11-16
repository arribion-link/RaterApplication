Imports System.Data.SqlClient
Imports System.Reflection.Metadata.Ecma335 ' (Kept as per your code, though not used)

Public Class Form1

    ' SQL Server Connection String (Update Server Name if needed)
    Private Const ConnectionString As String = "Server=(localdb)\MSSQLLocalDB;Database=FeedbackDB;Trusted_Connection=True;"

    Private Sub nameInput_TextChanged(sender As Object, e As EventArgs) Handles nameInput.TextChanged
        ValidateName()
    End Sub

    Private Sub commentInput_TextChanged(sender As Object, e As EventArgs) Handles commentInput.TextChanged
        ValidateComment()
    End Sub

    Private Sub one_star_CheckedChanged(sender As Object, e As EventArgs) Handles one_star.CheckedChanged
        If one_star.Checked Then selectedRating = 1
    End Sub

    Private Sub two_stars_CheckedChanged(sender As Object, e As EventArgs) Handles two_stars.CheckedChanged
        If two_stars.Checked Then selectedRating = 2
    End Sub

    Private Sub three_stars_CheckedChanged(sender As Object, e As EventArgs) Handles three_stars.CheckedChanged
        If three_stars.Checked Then selectedRating = 3
    End Sub

    Private Sub four_stars_CheckedChanged(sender As Object, e As EventArgs) Handles four_stars.CheckedChanged
        If four_stars.Checked Then selectedRating = 4
    End Sub

    Private Sub five_stars_CheckedChanged(sender As Object, e As EventArgs) Handles five_stars.CheckedChanged
        If five_stars.Checked Then selectedRating = 5
    End Sub

    ' Track selected rating
    Private selectedRating As Integer = 0

    ' Validate Name
    Private Sub ValidateName()
        Dim userName As String = nameInput.Text.Trim()
        If String.IsNullOrEmpty(userName) Then
            ErrorProvider.SetError(nameInput, "Name cannot be empty.")
        Else
            ErrorProvider.SetError(nameInput, "")
        End If
    End Sub

    ' Validate Comment
    Private Sub ValidateComment()
        Dim userComment As String = commentInput.Text.Trim()
        If String.IsNullOrEmpty(userComment) Then
            ErrorProvider.SetError(commentInput, "Comment cannot be empty.")
        Else
            ErrorProvider.SetError(commentInput, "")
        End If
    End Sub

    ' Submit Button Click
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim userName As String = nameInput.Text.Trim()
        Dim userComment As String = commentInput.Text.Trim()

        ' Final validation
        ValidateName()
        ValidateComment()

        If String.IsNullOrEmpty(userName) Then
            MessageBox.Show("Please enter your name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nameInput.Focus()
            Return
        End If

        If String.IsNullOrEmpty(userComment) Then
            MessageBox.Show("Please enter a comment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            commentInput.Focus()
            Return
        End If

        If selectedRating = 0 Then
            MessageBox.Show("Please select a star rating.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert into SQL Server
        If InsertFeedback(userName, userComment, selectedRating) Then
            MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputs()
            LoadFeedback()
        End If
    End Sub

    ' Insert into SQL Server
    Private Function InsertFeedback(name As String, comment As String, rating As Integer) As Boolean
        Dim query As String = "INSERT INTO UserFeedback (UserName, Comment, Rating) VALUES (@Name, @Comment, @Rating)"

        Try
            Using conn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Comment", comment)
                    cmd.Parameters.AddWithValue("@Rating", rating)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As SqlException
            MessageBox.Show("Database error: " & ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Load all feedback into ListBox
    Private Sub LoadFeedback()
        userListField.Items.Clear()
        Dim query As String = "SELECT UserName, Comment, Rating FROM UserFeedback ORDER BY Id DESC"

        Try
            Using conn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim name As String = reader("UserName").ToString()
                            Dim comment As String = reader("Comment").ToString()
                            Dim rating As Integer = Convert.ToInt32(reader("Rating"))
                            Dim stars As String = New String("★"c, rating) & New String("☆"c, 5 - rating)
                            userListField.Items.Add($"{name} - {stars} - {comment}")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load feedback: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Clear Inputs
    Private Function ClearInputs() As Boolean
        nameInput.Text = ""
        commentInput.Text = ""
        one_star.Checked = False
        two_stars.Checked = False
        three_stars.Checked = False
        four_stars.Checked = False
        five_stars.Checked = False
        selectedRating = 0
        ErrorProvider.Clear()
        Return True
    End Function

    ' Clear Button
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        ClearInputs()
    End Sub

    ' Optional: Load data when form starts
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFeedback()
    End Sub

    ' Optional: Show selected item details (if needed)
    Private Sub userListField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userListField.SelectedIndexChanged
        ' You can expand this to show details in labels, etc.
    End Sub

End Class