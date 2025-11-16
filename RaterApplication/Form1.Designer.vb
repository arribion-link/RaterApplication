<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        userListField = New ListView()
        Label1 = New Label()
        username = New Label()
        usercomment = New Label()
        Label4 = New Label()
        nameInput = New TextBox()
        commentInput = New TextBox()
        clearBtn = New Button()
        submitBtn = New Button()
        one_star = New RadioButton()
        two_stars = New RadioButton()
        three_stars = New RadioButton()
        four_stars = New RadioButton()
        five_stars = New RadioButton()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' userListField
        ' 
        userListField.BackColor = SystemColors.ControlLightLight
        userListField.Location = New Point(501, 604)
        userListField.Name = "userListField"
        userListField.Size = New Size(908, 315)
        userListField.TabIndex = 0
        userListField.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(841, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 25)
        Label1.TabIndex = 1
        Label1.Text = "Rating Collection Application"
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Location = New Point(501, 110)
        username.Name = "username"
        username.Size = New Size(63, 25)
        username.TabIndex = 2
        username.Text = "Name:"
        ' 
        ' usercomment
        ' 
        usercomment.AutoSize = True
        usercomment.Location = New Point(501, 214)
        usercomment.Name = "usercomment"
        usercomment.Size = New Size(95, 25)
        usercomment.TabIndex = 3
        usercomment.Text = "Comment:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(501, 576)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 4
        Label4.Text = "User Rating's"
        ' 
        ' nameInput
        ' 
        nameInput.BackColor = SystemColors.GradientInactiveCaption
        nameInput.Location = New Point(501, 148)
        nameInput.Name = "nameInput"
        nameInput.Size = New Size(908, 31)
        nameInput.TabIndex = 7
        ' 
        ' commentInput
        ' 
        commentInput.BackColor = SystemColors.GradientInactiveCaption
        commentInput.Location = New Point(501, 242)
        commentInput.Multiline = True
        commentInput.Name = "commentInput"
        commentInput.Size = New Size(908, 124)
        commentInput.TabIndex = 8
        ' 
        ' clearBtn
        ' 
        clearBtn.BackColor = Color.LightSkyBlue
        clearBtn.ForeColor = Color.Black
        clearBtn.Location = New Point(501, 492)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(357, 52)
        clearBtn.TabIndex = 9
        clearBtn.Text = "CLEAR"
        clearBtn.UseVisualStyleBackColor = False
        ' 
        ' submitBtn
        ' 
        submitBtn.BackColor = SystemColors.MenuHighlight
        submitBtn.ForeColor = Color.Linen
        submitBtn.Location = New Point(1062, 492)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(347, 52)
        submitBtn.TabIndex = 10
        submitBtn.Text = "SUBMIT"
        submitBtn.UseVisualStyleBackColor = False
        ' 
        ' one_star
        ' 
        one_star.AutoSize = True
        one_star.ForeColor = Color.LightCoral
        one_star.Location = New Point(621, 409)
        one_star.Name = "one_star"
        one_star.Size = New Size(81, 29)
        one_star.TabIndex = 11
        one_star.TabStop = True
        one_star.Text = "1 star"
        one_star.UseVisualStyleBackColor = True
        ' 
        ' two_stars
        ' 
        two_stars.AutoSize = True
        two_stars.ForeColor = Color.DarkRed
        two_stars.Location = New Point(769, 409)
        two_stars.Name = "two_stars"
        two_stars.Size = New Size(89, 29)
        two_stars.TabIndex = 13
        two_stars.TabStop = True
        two_stars.Text = "2 stars"
        two_stars.UseVisualStyleBackColor = True
        ' 
        ' three_stars
        ' 
        three_stars.AutoSize = True
        three_stars.ForeColor = Color.DarkRed
        three_stars.Location = New Point(950, 409)
        three_stars.Name = "three_stars"
        three_stars.Size = New Size(89, 29)
        three_stars.TabIndex = 14
        three_stars.TabStop = True
        three_stars.Text = "3 stars"
        three_stars.UseVisualStyleBackColor = True
        ' 
        ' four_stars
        ' 
        four_stars.AutoSize = True
        four_stars.ForeColor = Color.Red
        four_stars.Location = New Point(1128, 409)
        four_stars.Name = "four_stars"
        four_stars.Size = New Size(89, 29)
        four_stars.TabIndex = 15
        four_stars.TabStop = True
        four_stars.Text = "4 stars"
        four_stars.UseVisualStyleBackColor = True
        ' 
        ' five_stars
        ' 
        five_stars.AutoSize = True
        five_stars.ForeColor = Color.Red
        five_stars.Location = New Point(1320, 409)
        five_stars.Name = "five_stars"
        five_stars.Size = New Size(89, 29)
        five_stars.TabIndex = 16
        five_stars.TabStop = True
        five_stars.Text = "5 stars"
        five_stars.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(501, 409)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 17
        Label2.Text = "Ratings:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(1531, 942)
        Controls.Add(Label2)
        Controls.Add(five_stars)
        Controls.Add(four_stars)
        Controls.Add(three_stars)
        Controls.Add(two_stars)
        Controls.Add(one_star)
        Controls.Add(submitBtn)
        Controls.Add(clearBtn)
        Controls.Add(commentInput)
        Controls.Add(nameInput)
        Controls.Add(Label4)
        Controls.Add(usercomment)
        Controls.Add(username)
        Controls.Add(Label1)
        Controls.Add(userListField)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userListField As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents username As Label
    Friend WithEvents usercomment As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameInput As TextBox
    Friend WithEvents commentInput As TextBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents submitBtn As Button
    Friend WithEvents one_star As RadioButton
    Friend WithEvents two_stars As RadioButton
    Friend WithEvents three_stars As RadioButton
    Friend WithEvents four_stars As RadioButton
    Friend WithEvents five_stars As RadioButton
    Friend WithEvents Label2 As Label

End Class
