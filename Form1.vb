Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PanelRegistrationandEditUserData.Visible = False
        PanelUserData.Visible = False
        PanelConnection.Visible = True
    End Sub

    Private Sub buttonConnection_Click(sender As Object, e As EventArgs) Handles buttonConnection.Click
        PictureBoxSelect.Top = buttonConnection.Top
        PanelRegistrationandEditUserData.Visible = False
        PanelUserData.Visible = False
        PanelConnection.Visible = True
    End Sub

    Private Sub buttonUserData_Click(sender As Object, e As EventArgs) Handles buttonUserData.Click
        PictureBoxSelect.Top = buttonUserData.Top
        PanelConnection.Visible = False
        PanelRegistrationandEditUserData.Visible = False
        PanelUserData.Visible = True

    End Sub

    Private Sub buttonRegistration_Click(sender As Object, e As EventArgs) Handles buttonRegistration.Click
        PictureBoxSelect.Top = buttonRegistration.Top
        PanelUserData.Visible = False
        PanelConnection.Visible = False
        PanelRegistrationandEditUserData.Visible = True
    End Sub

    Private Sub PanelConnection_Paint(sender As Object, e As PaintEventArgs) Handles PanelConnection.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelConnection_Resize(sender As Object, e As EventArgs) Handles PanelConnection.Resize
        PanelConnection.Invalidate()
    End Sub

    Private Sub buttonScanPort_Click(sender As Object, e As EventArgs) Handles buttonScanPort.Click

    End Sub

    Private Sub buttonScanPort_MouseHover(sender As Object, e As EventArgs) Handles buttonScanPort.MouseHover
        buttonScanPort.ForeColor = Color.White
    End Sub

    Private Sub buttonScanPort_MouseLeave(sender As Object, e As EventArgs) Handles buttonScanPort.MouseLeave
        buttonScanPort.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GroupBoxImage.Location = New Point((PanelUserData.Width / 2) - (GroupBoxImage.Width / 2), GroupBoxImage.Top)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBoxUserImage_Click(sender As Object, e As EventArgs) Handles PictureBoxUserImage.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNom.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBoxImageInput.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByName.CheckedChanged

    End Sub

    Private Sub PanelUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelUserData_Resize(sender As Object, e As EventArgs) Handles PanelUserData.Resize
        PanelUserData.Invalidate()
    End Sub

    Private Sub PanelRegistrationandEditUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelRegistrationandEditUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelRegistrationandEditUserData_Resize(sender As Object, e As EventArgs) Handles PanelRegistrationandEditUserData.Resize
        PanelRegistrationandEditUserData.Invalidate()
    End Sub
End Class
