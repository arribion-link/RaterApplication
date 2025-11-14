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
        commentBtn = New TextBox()
        clearBtn = New Button()
        submitBtn = New Button()
        SuspendLayout()
        ' 
        ' userListField
        ' 
        userListField.BackColor = SystemColors.InactiveCaption
        userListField.Location = New Point(28, 405)
        userListField.Name = "userListField"
        userListField.Size = New Size(908, 253)
        userListField.TabIndex = 0
        userListField.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(368, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 25)
        Label1.TabIndex = 1
        Label1.Text = "Rating Collection Application"
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Location = New Point(28, 86)
        username.Name = "username"
        username.Size = New Size(63, 25)
        username.TabIndex = 2
        username.Text = "Name:"
        ' 
        ' usercomment
        ' 
        usercomment.AutoSize = True
        usercomment.Location = New Point(28, 190)
        usercomment.Name = "usercomment"
        usercomment.Size = New Size(95, 25)
        usercomment.TabIndex = 3
        usercomment.Text = "Comment:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 377)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 4
        Label4.Text = "User Rating's"
        ' 
        ' nameInput
        ' 
        nameInput.BackColor = SystemColors.GradientInactiveCaption
        nameInput.Location = New Point(28, 124)
        nameInput.Name = "nameInput"
        nameInput.Size = New Size(890, 31)
        nameInput.TabIndex = 7
        ' 
        ' commentBtn
        ' 
        commentBtn.BackColor = SystemColors.GradientInactiveCaption
        commentBtn.Location = New Point(28, 218)
        commentBtn.Name = "commentBtn"
        commentBtn.Size = New Size(908, 31)
        commentBtn.TabIndex = 8
        ' 
        ' clearBtn
        ' 
        clearBtn.BackColor = SystemColors.HotTrack
        clearBtn.ForeColor = Color.Black
        clearBtn.Location = New Point(28, 278)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(400, 75)
        clearBtn.TabIndex = 9
        clearBtn.Text = "CLEAR"
        clearBtn.UseVisualStyleBackColor = False
        ' 
        ' submitBtn
        ' 
        submitBtn.BackColor = SystemColors.MenuHighlight
        submitBtn.ForeColor = Color.Linen
        submitBtn.Location = New Point(538, 278)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(398, 75)
        submitBtn.TabIndex = 10
        submitBtn.Text = "SUBMIT"
        submitBtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(974, 670)
        Controls.Add(submitBtn)
        Controls.Add(clearBtn)
        Controls.Add(commentBtn)
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
    Friend WithEvents commentBtn As TextBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents submitBtn As Button

End Class
