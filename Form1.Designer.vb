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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelMenu = New Panel()
        PictureBoxSelect = New PictureBox()
        buttonRegistration = New Button()
        buttonUserData = New Button()
        buttonConnection = New Button()
        PictureBoxLogo = New PictureBox()
        LabelConnectionStatus = New Label()
        PictureBox1 = New PictureBox()
        LabelDateTime = New Label()
        PanelConnection = New Panel()
        Panel1 = New Panel()
        buttonConnect = New Button()
        ComboBoxBaudRate = New ComboBox()
        Label = New Label()
        ComboBoxPort = New ComboBox()
        buttonScanPort = New Button()
        PanelRegistrationandEditUserData = New Panel()
        PanelReadingTagProcess = New Panel()
        Button1 = New Button()
        GroupBox3 = New GroupBox()
        PictureBoxImagePreview = New PictureBox()
        DataGridView1 = New DataGridView()
        CheckBoxByID = New CheckBox()
        CheckBoxByName = New CheckBox()
        TextBoxSearch = New TextBox()
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        PictureBoxImageInput = New PictureBox()
        GroupBox1 = New GroupBox()
        LabelGetID = New Label()
        Label5 = New Label()
        buttonScanID = New Button()
        buttonClearForm = New Button()
        buttonSave = New Button()
        TextBoxadresse = New TextBox()
        TextBoxVille = New TextBox()
        TextBoxDep = New TextBox()
        label4 = New Label()
        label3 = New Label()
        Label2 = New Label()
        TextBoxNom = New TextBox()
        label1 = New Label()
        PanelUserData = New Panel()
        GroupBox = New GroupBox()
        LabelCity = New Label()
        labelville = New Label()
        LabelAddress = New Label()
        labeladress = New Label()
        LabelDepartment = New Label()
        buttonClear = New Button()
        LabelName = New Label()
        LabelDep = New Label()
        labelnom = New Label()
        GroupBoxImage = New GroupBox()
        LabelID = New Label()
        PictureBoxUserImage = New PictureBox()
        buttonCloseReadingTag = New Button()
        PictureBox2 = New PictureBox()
        PanelMenu.SuspendLayout()
        CType(PictureBoxSelect, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelConnection.SuspendLayout()
        PanelRegistrationandEditUserData.SuspendLayout()
        PanelReadingTagProcess.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBoxImagePreview, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBoxImageInput, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        PanelUserData.SuspendLayout()
        GroupBox.SuspendLayout()
        GroupBoxImage.SuspendLayout()
        CType(PictureBoxUserImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PanelMenu.BackColor = Color.FromArgb(CByte(6), CByte(71), CByte(165))
        PanelMenu.Controls.Add(PictureBoxSelect)
        PanelMenu.Controls.Add(buttonRegistration)
        PanelMenu.Controls.Add(buttonUserData)
        PanelMenu.Controls.Add(buttonConnection)
        PanelMenu.Controls.Add(PictureBoxLogo)
        PanelMenu.Location = New Point(2, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(324, 693)
        PanelMenu.TabIndex = 0
        PanelMenu.UseWaitCursor = True
        ' 
        ' PictureBoxSelect
        ' 
        PictureBoxSelect.Image = My.Resources.Resources.iconfinder_arrow138_216456
        PictureBoxSelect.Location = New Point(0, 162)
        PictureBoxSelect.Name = "PictureBoxSelect"
        PictureBoxSelect.Size = New Size(18, 36)
        PictureBoxSelect.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxSelect.TabIndex = 1
        PictureBoxSelect.TabStop = False
        PictureBoxSelect.UseWaitCursor = True
        ' 
        ' buttonRegistration
        ' 
        buttonRegistration.FlatAppearance.BorderColor = Color.FromArgb(CByte(6), CByte(71), CByte(165))
        buttonRegistration.FlatStyle = FlatStyle.Flat
        buttonRegistration.ForeColor = Color.White
        buttonRegistration.Image = My.Resources.Resources.iconfinder_document_text_accept_103510_2_
        buttonRegistration.ImageAlign = ContentAlignment.MiddleLeft
        buttonRegistration.Location = New Point(22, 281)
        buttonRegistration.Name = "buttonRegistration"
        buttonRegistration.Size = New Size(321, 35)
        buttonRegistration.TabIndex = 3
        buttonRegistration.Text = "Enregistrer / Editer Utilisateur"
        buttonRegistration.UseVisualStyleBackColor = True
        buttonRegistration.UseWaitCursor = True
        ' 
        ' buttonUserData
        ' 
        buttonUserData.FlatAppearance.BorderColor = Color.FromArgb(CByte(6), CByte(71), CByte(165))
        buttonUserData.FlatStyle = FlatStyle.Flat
        buttonUserData.ForeColor = Color.White
        buttonUserData.Image = My.Resources.Resources.iconfinder_Computer__Computer_Hardware_USB_Port_Connection_4064143_1_1
        buttonUserData.ImageAlign = ContentAlignment.MiddleLeft
        buttonUserData.Location = New Point(22, 216)
        buttonUserData.Name = "buttonUserData"
        buttonUserData.Size = New Size(302, 47)
        buttonUserData.TabIndex = 2
        buttonUserData.Text = "Données Utilisateur"
        buttonUserData.UseVisualStyleBackColor = True
        buttonUserData.UseWaitCursor = True
        ' 
        ' buttonConnection
        ' 
        buttonConnection.FlatAppearance.BorderColor = Color.FromArgb(CByte(6), CByte(71), CByte(165))
        buttonConnection.FlatStyle = FlatStyle.Flat
        buttonConnection.ForeColor = Color.White
        buttonConnection.Image = My.Resources.Resources.iconfinder_Computer__Computer_Hardware_USB_Port_Connection_4064143_1_
        buttonConnection.ImageAlign = ContentAlignment.MiddleLeft
        buttonConnection.Location = New Point(22, 161)
        buttonConnection.Name = "buttonConnection"
        buttonConnection.Size = New Size(302, 35)
        buttonConnection.TabIndex = 1
        buttonConnection.Text = "Connexion"
        buttonConnection.UseVisualStyleBackColor = True
        buttonConnection.UseWaitCursor = True
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.Image = My.Resources.Resources.userrfid
        PictureBoxLogo.Location = New Point(62, 21)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(200, 121)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 1
        PictureBoxLogo.TabStop = False
        PictureBoxLogo.UseWaitCursor = True
        ' 
        ' LabelConnectionStatus
        ' 
        LabelConnectionStatus.AutoSize = True
        LabelConnectionStatus.Location = New Point(330, 4)
        LabelConnectionStatus.Name = "LabelConnectionStatus"
        LabelConnectionStatus.Size = New Size(209, 17)
        LabelConnectionStatus.TabIndex = 1
        LabelConnectionStatus.Text = "Etat de connexion : Déconnecté"
        LabelConnectionStatus.UseWaitCursor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Disconnect
        PictureBox1.Location = New Point(562, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 17)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' LabelDateTime
        ' 
        LabelDateTime.AutoSize = True
        LabelDateTime.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelDateTime.Location = New Point(728, 5)
        LabelDateTime.Name = "LabelDateTime"
        LabelDateTime.Size = New Size(262, 16)
        LabelDateTime.TabIndex = 3
        LabelDateTime.Text = "Time 00:00:00 Date 00 mmm; 0000"
        LabelDateTime.UseWaitCursor = True
        ' 
        ' PanelConnection
        ' 
        PanelConnection.Controls.Add(Panel1)
        PanelConnection.Controls.Add(buttonConnect)
        PanelConnection.Controls.Add(ComboBoxBaudRate)
        PanelConnection.Controls.Add(Label)
        PanelConnection.Controls.Add(ComboBoxPort)
        PanelConnection.Controls.Add(buttonScanPort)
        PanelConnection.ForeColor = Color.FromArgb(CByte(6), CByte(71), CByte(165))
        PanelConnection.Location = New Point(330, 30)
        PanelConnection.Name = "PanelConnection"
        PanelConnection.Size = New Size(588, 546)
        PanelConnection.TabIndex = 4
        PanelConnection.UseWaitCursor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(588, 5)
        Panel1.TabIndex = 0
        Panel1.UseWaitCursor = True
        ' 
        ' buttonConnect
        ' 
        buttonConnect.BackColor = Color.WhiteSmoke
        buttonConnect.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        buttonConnect.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(95), CByte(215))
        buttonConnect.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(49), CByte(114), CByte(210))
        buttonConnect.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonConnect.Location = New Point(14, 65)
        buttonConnect.Name = "buttonConnect"
        buttonConnect.Size = New Size(555, 30)
        buttonConnect.TabIndex = 7
        buttonConnect.Text = "Connecté"
        buttonConnect.UseVisualStyleBackColor = False
        buttonConnect.UseWaitCursor = True
        ' 
        ' ComboBoxBaudRate
        ' 
        ComboBoxBaudRate.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxBaudRate.FormattingEnabled = True
        ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600 ", "14400", "19200", "38400", "57600", "115200"})
        ComboBoxBaudRate.Location = New Point(495, 20)
        ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        ComboBoxBaudRate.Size = New Size(90, 25)
        ComboBoxBaudRate.TabIndex = 6
        ComboBoxBaudRate.UseWaitCursor = True
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label.ForeColor = Color.FromArgb(CByte(6), CByte(71), CByte(165))
        Label.Location = New Point(434, 25)
        Label.Name = "Label"
        Label.Size = New Size(60, 15)
        Label.TabIndex = 5
        Label.Text = "vitesse :"
        Label.UseWaitCursor = True
        ' 
        ' ComboBoxPort
        ' 
        ComboBoxPort.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPort.FormattingEnabled = True
        ComboBoxPort.Location = New Point(145, 20)
        ComboBoxPort.Name = "ComboBoxPort"
        ComboBoxPort.Size = New Size(265, 25)
        ComboBoxPort.TabIndex = 2
        ComboBoxPort.UseWaitCursor = True
        ' 
        ' buttonScanPort
        ' 
        buttonScanPort.BackColor = Color.WhiteSmoke
        buttonScanPort.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        buttonScanPort.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(95), CByte(215))
        buttonScanPort.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(49), CByte(114), CByte(210))
        buttonScanPort.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonScanPort.Location = New Point(14, 20)
        buttonScanPort.Name = "buttonScanPort"
        buttonScanPort.Size = New Size(123, 29)
        buttonScanPort.TabIndex = 1
        buttonScanPort.Text = "Scanner le port"
        buttonScanPort.UseVisualStyleBackColor = False
        buttonScanPort.UseWaitCursor = True
        ' 
        ' PanelRegistrationandEditUserData
        ' 
        PanelRegistrationandEditUserData.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelRegistrationandEditUserData.Controls.Add(PanelReadingTagProcess)
        PanelRegistrationandEditUserData.Controls.Add(GroupBox3)
        PanelRegistrationandEditUserData.Controls.Add(GroupBox2)
        PanelRegistrationandEditUserData.Controls.Add(GroupBox1)
        PanelRegistrationandEditUserData.Controls.Add(buttonClearForm)
        PanelRegistrationandEditUserData.Controls.Add(buttonSave)
        PanelRegistrationandEditUserData.Controls.Add(TextBoxadresse)
        PanelRegistrationandEditUserData.Controls.Add(TextBoxVille)
        PanelRegistrationandEditUserData.Controls.Add(TextBoxDep)
        PanelRegistrationandEditUserData.Controls.Add(label4)
        PanelRegistrationandEditUserData.Controls.Add(label3)
        PanelRegistrationandEditUserData.Controls.Add(Label2)
        PanelRegistrationandEditUserData.Controls.Add(TextBoxNom)
        PanelRegistrationandEditUserData.Controls.Add(label1)
        PanelRegistrationandEditUserData.Location = New Point(330, 27)
        PanelRegistrationandEditUserData.Name = "PanelRegistrationandEditUserData"
        PanelRegistrationandEditUserData.Size = New Size(640, 576)
        PanelRegistrationandEditUserData.TabIndex = 2
        PanelRegistrationandEditUserData.UseWaitCursor = True
        ' 
        ' PanelReadingTagProcess
        ' 
        PanelReadingTagProcess.Controls.Add(PictureBox2)
        PanelReadingTagProcess.Controls.Add(buttonCloseReadingTag)
        PanelReadingTagProcess.Controls.Add(Button1)
        PanelReadingTagProcess.Location = New Point(0, 11)
        PanelReadingTagProcess.Name = "PanelReadingTagProcess"
        PanelReadingTagProcess.Size = New Size(264, 165)
        PanelReadingTagProcess.TabIndex = 21
        PanelReadingTagProcess.UseWaitCursor = True
        PanelReadingTagProcess.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(95), CByte(215))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(49), CByte(114), CByte(210))
        Button1.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 42)
        Button1.TabIndex = 10
        Button1.Text = "Lecture de la carte..."
        Button1.UseVisualStyleBackColor = False
        Button1.UseWaitCursor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(PictureBoxImagePreview)
        GroupBox3.Controls.Add(DataGridView1)
        GroupBox3.Controls.Add(CheckBoxByID)
        GroupBox3.Controls.Add(CheckBoxByName)
        GroupBox3.Controls.Add(TextBoxSearch)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(22, 335)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(553, 238)
        GroupBox3.TabIndex = 14
        GroupBox3.TabStop = False
        GroupBox3.Text = "Enregistrements"
        GroupBox3.UseWaitCursor = True
        ' 
        ' PictureBoxImagePreview
        ' 
        PictureBoxImagePreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBoxImagePreview.BorderStyle = BorderStyle.FixedSingle
        PictureBoxImagePreview.Location = New Point(434, 79)
        PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        PictureBoxImagePreview.Size = New Size(110, 110)
        PictureBoxImagePreview.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxImagePreview.TabIndex = 20
        PictureBoxImagePreview.TabStop = False
        PictureBoxImagePreview.UseWaitCursor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(9, 74)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(379, 154)
        DataGridView1.TabIndex = 19
        DataGridView1.UseWaitCursor = True
        ' 
        ' CheckBoxByID
        ' 
        CheckBoxByID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        CheckBoxByID.AutoSize = True
        CheckBoxByID.Location = New Point(373, 54)
        CheckBoxByID.Name = "CheckBoxByID"
        CheckBoxByID.Size = New Size(133, 19)
        CheckBoxByID.TabIndex = 18
        CheckBoxByID.Text = "Chercher par ID"
        CheckBoxByID.UseVisualStyleBackColor = True
        CheckBoxByID.UseWaitCursor = True
        ' 
        ' CheckBoxByName
        ' 
        CheckBoxByName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckBoxByName.AutoSize = True
        CheckBoxByName.Checked = True
        CheckBoxByName.CheckState = CheckState.Checked
        CheckBoxByName.Location = New Point(373, 29)
        CheckBoxByName.Name = "CheckBoxByName"
        CheckBoxByName.Size = New Size(147, 19)
        CheckBoxByName.TabIndex = 17
        CheckBoxByName.Text = "Chercher par nom"
        CheckBoxByName.UseVisualStyleBackColor = True
        CheckBoxByName.UseWaitCursor = True
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxSearch.Location = New Point(119, 25)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(248, 23)
        TextBoxSearch.TabIndex = 16
        TextBoxSearch.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(6, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 15)
        Label6.TabIndex = 15
        Label6.Text = "Rechercher ici"
        Label6.UseWaitCursor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(PictureBoxImageInput)
        GroupBox2.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(455, 200)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(120, 130)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Photo"
        GroupBox2.UseWaitCursor = True
        ' 
        ' PictureBoxImageInput
        ' 
        PictureBoxImageInput.BorderStyle = BorderStyle.FixedSingle
        PictureBoxImageInput.Location = New Point(10, 22)
        PictureBoxImageInput.Name = "PictureBoxImageInput"
        PictureBoxImageInput.Size = New Size(100, 100)
        PictureBoxImageInput.TabIndex = 13
        PictureBoxImageInput.TabStop = False
        PictureBoxImageInput.UseWaitCursor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox1.Controls.Add(LabelGetID)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(buttonScanID)
        GroupBox1.Location = New Point(329, 200)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(120, 130)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Recuperer ID"
        GroupBox1.UseWaitCursor = True
        ' 
        ' LabelGetID
        ' 
        LabelGetID.AutoSize = True
        LabelGetID.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelGetID.ForeColor = Color.Black
        LabelGetID.Location = New Point(30, 98)
        LabelGetID.Name = "LabelGetID"
        LabelGetID.Size = New Size(74, 15)
        LabelGetID.TabIndex = 14
        LabelGetID.Text = "._________"
        LabelGetID.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(6, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(21, 15)
        Label5.TabIndex = 13
        Label5.Text = "ID"
        Label5.UseWaitCursor = True
        ' 
        ' buttonScanID
        ' 
        buttonScanID.BackColor = Color.WhiteSmoke
        buttonScanID.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        buttonScanID.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(95), CByte(215))
        buttonScanID.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(49), CByte(114), CByte(210))
        buttonScanID.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonScanID.Location = New Point(6, 22)
        buttonScanID.Name = "buttonScanID"
        buttonScanID.Size = New Size(108, 49)
        buttonScanID.TabIndex = 12
        buttonScanID.Text = "Scanner"
        buttonScanID.UseVisualStyleBackColor = False
        buttonScanID.UseWaitCursor = True
        ' 
        ' buttonClearForm
        ' 
        buttonClearForm.BackColor = Color.WhiteSmoke
        buttonClearForm.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        buttonClearForm.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(95), CByte(215))
        buttonClearForm.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(49), CByte(114), CByte(210))
        buttonClearForm.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonClearForm.Location = New Point(113, 203)
        buttonClearForm.Name = "buttonClearForm"
        buttonClearForm.Size = New Size(93, 30)
        buttonClearForm.TabIndex = 10
        buttonClearForm.Text = "Effacer"
        buttonClearForm.UseVisualStyleBackColor = False
        buttonClearForm.UseWaitCursor = True
        ' 
        ' buttonSave
        ' 
        buttonSave.BackColor = Color.WhiteSmoke
        buttonSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        buttonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(95), CByte(215))
        buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(49), CByte(114), CByte(210))
        buttonSave.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonSave.Location = New Point(14, 203)
        buttonSave.Name = "buttonSave"
        buttonSave.Size = New Size(93, 30)
        buttonSave.TabIndex = 9
        buttonSave.Text = "Enregistrer"
        buttonSave.UseVisualStyleBackColor = False
        buttonSave.UseWaitCursor = True
        ' 
        ' TextBoxadresse
        ' 
        TextBoxadresse.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxadresse.Location = New Point(93, 53)
        TextBoxadresse.Name = "TextBoxadresse"
        TextBoxadresse.Size = New Size(544, 23)
        TextBoxadresse.TabIndex = 8
        TextBoxadresse.UseWaitCursor = True
        ' 
        ' TextBoxVille
        ' 
        TextBoxVille.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxVille.Location = New Point(93, 99)
        TextBoxVille.Name = "TextBoxVille"
        TextBoxVille.Size = New Size(544, 23)
        TextBoxVille.TabIndex = 7
        TextBoxVille.UseWaitCursor = True
        ' 
        ' TextBoxDep
        ' 
        TextBoxDep.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxDep.Location = New Point(93, 148)
        TextBoxDep.Name = "TextBoxDep"
        TextBoxDep.Size = New Size(544, 23)
        TextBoxDep.TabIndex = 6
        TextBoxDep.UseWaitCursor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label4.ForeColor = Color.Black
        label4.Location = New Point(3, 61)
        label4.Name = "label4"
        label4.Size = New Size(60, 15)
        label4.TabIndex = 5
        label4.Text = "Adresse"
        label4.UseWaitCursor = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label3.ForeColor = Color.Black
        label3.Location = New Point(3, 107)
        label3.Name = "label3"
        label3.Size = New Size(36, 15)
        label3.TabIndex = 4
        label3.Text = "Ville"
        label3.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 3
        Label2.Text = "Département "
        Label2.UseWaitCursor = True
        ' 
        ' TextBoxNom
        ' 
        TextBoxNom.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxNom.Location = New Point(93, 15)
        TextBoxNom.Name = "TextBoxNom"
        TextBoxNom.Size = New Size(544, 23)
        TextBoxNom.TabIndex = 2
        TextBoxNom.UseWaitCursor = True
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = Color.Black
        label1.Location = New Point(3, 18)
        label1.Name = "label1"
        label1.Size = New Size(43, 15)
        label1.TabIndex = 1
        label1.Text = "Nom  "
        label1.UseWaitCursor = True
        ' 
        ' PanelUserData
        ' 
        PanelUserData.Controls.Add(GroupBox)
        PanelUserData.Controls.Add(GroupBoxImage)
        PanelUserData.ForeColor = Color.FromArgb(CByte(6), CByte(71), CByte(165))
        PanelUserData.Location = New Point(332, 27)
        PanelUserData.Name = "PanelUserData"
        PanelUserData.Size = New Size(588, 546)
        PanelUserData.TabIndex = 5
        PanelUserData.UseWaitCursor = True
        ' 
        ' GroupBox
        ' 
        GroupBox.Controls.Add(LabelCity)
        GroupBox.Controls.Add(labelville)
        GroupBox.Controls.Add(LabelAddress)
        GroupBox.Controls.Add(labeladress)
        GroupBox.Controls.Add(LabelDepartment)
        GroupBox.Controls.Add(buttonClear)
        GroupBox.Controls.Add(LabelName)
        GroupBox.Controls.Add(LabelDep)
        GroupBox.Controls.Add(labelnom)
        GroupBox.Location = New Point(14, 271)
        GroupBox.Name = "GroupBox"
        GroupBox.Size = New Size(555, 263)
        GroupBox.TabIndex = 1
        GroupBox.TabStop = False
        GroupBox.Text = "Detail Données"
        GroupBox.UseWaitCursor = True
        ' 
        ' LabelCity
        ' 
        LabelCity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelCity.AutoSize = True
        LabelCity.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelCity.ForeColor = Color.Black
        LabelCity.Location = New Point(131, 154)
        LabelCity.Name = "LabelCity"
        LabelCity.Size = New Size(81, 15)
        LabelCity.TabIndex = 8
        LabelCity.Text = "Patientez..."
        LabelCity.UseWaitCursor = True
        ' 
        ' labelville
        ' 
        labelville.AutoSize = True
        labelville.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelville.ForeColor = Color.Black
        labelville.Location = New Point(6, 154)
        labelville.Name = "labelville"
        labelville.Size = New Size(106, 15)
        labelville.TabIndex = 7
        labelville.Text = "Ville                      :"
        labelville.UseWaitCursor = True
        ' 
        ' LabelAddress
        ' 
        LabelAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelAddress.AutoSize = True
        LabelAddress.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelAddress.ForeColor = Color.Black
        LabelAddress.Location = New Point(131, 91)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(81, 15)
        LabelAddress.TabIndex = 6
        LabelAddress.Text = "Patientez..."
        LabelAddress.UseWaitCursor = True
        ' 
        ' labeladress
        ' 
        labeladress.AutoSize = True
        labeladress.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labeladress.ForeColor = Color.Black
        labeladress.Location = New Point(6, 91)
        labeladress.Name = "labeladress"
        labeladress.Size = New Size(106, 15)
        labeladress.TabIndex = 5
        labeladress.Text = "Adresse              :"
        labeladress.UseWaitCursor = True
        ' 
        ' LabelDepartment
        ' 
        LabelDepartment.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelDepartment.AutoSize = True
        LabelDepartment.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDepartment.ForeColor = Color.Black
        LabelDepartment.Location = New Point(131, 209)
        LabelDepartment.Name = "LabelDepartment"
        LabelDepartment.Size = New Size(81, 15)
        LabelDepartment.TabIndex = 4
        LabelDepartment.Text = "Patientez..."
        LabelDepartment.UseWaitCursor = True
        ' 
        ' buttonClear
        ' 
        buttonClear.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        buttonClear.BackColor = Color.WhiteSmoke
        buttonClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(70), CByte(180))
        buttonClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(95), CByte(215))
        buttonClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(49), CByte(114), CByte(210))
        buttonClear.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonClear.Location = New Point(477, 229)
        buttonClear.Name = "buttonClear"
        buttonClear.Size = New Size(68, 21)
        buttonClear.TabIndex = 3
        buttonClear.Text = "Clear"
        buttonClear.UseVisualStyleBackColor = False
        buttonClear.UseWaitCursor = True
        ' 
        ' LabelName
        ' 
        LabelName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelName.AutoSize = True
        LabelName.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelName.ForeColor = Color.Black
        LabelName.Location = New Point(131, 28)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(81, 15)
        LabelName.TabIndex = 2
        LabelName.Text = "Patientez..."
        LabelName.UseWaitCursor = True
        ' 
        ' LabelDep
        ' 
        LabelDep.AutoSize = True
        LabelDep.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDep.ForeColor = Color.Black
        LabelDep.Location = New Point(6, 209)
        LabelDep.Name = "LabelDep"
        LabelDep.Size = New Size(106, 15)
        LabelDep.TabIndex = 1
        LabelDep.Text = "Département   :"
        LabelDep.UseWaitCursor = True
        ' 
        ' labelnom
        ' 
        labelnom.AutoSize = True
        labelnom.Font = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelnom.ForeColor = Color.Black
        labelnom.Location = New Point(6, 28)
        labelnom.Name = "labelnom"
        labelnom.Size = New Size(107, 15)
        labelnom.TabIndex = 0
        labelnom.Text = "Nom                      :"
        labelnom.UseWaitCursor = True
        ' 
        ' GroupBoxImage
        ' 
        GroupBoxImage.Controls.Add(LabelID)
        GroupBoxImage.Controls.Add(PictureBoxUserImage)
        GroupBoxImage.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBoxImage.Location = New Point(332, 20)
        GroupBoxImage.Name = "GroupBoxImage"
        GroupBoxImage.Size = New Size(208, 239)
        GroupBoxImage.TabIndex = 0
        GroupBoxImage.TabStop = False
        GroupBoxImage.Text = "Image and ID"
        GroupBoxImage.UseWaitCursor = True
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelID.ForeColor = Color.Black
        LabelID.Location = New Point(28, 205)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(130, 20)
        LabelID.TabIndex = 2
        LabelID.Text = "ID : __________"
        LabelID.UseWaitCursor = True
        ' 
        ' PictureBoxUserImage
        ' 
        PictureBoxUserImage.BorderStyle = BorderStyle.FixedSingle
        PictureBoxUserImage.Location = New Point(18, 24)
        PictureBoxUserImage.Name = "PictureBoxUserImage"
        PictureBoxUserImage.Size = New Size(174, 174)
        PictureBoxUserImage.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxUserImage.TabIndex = 1
        PictureBoxUserImage.TabStop = False
        PictureBoxUserImage.UseWaitCursor = True
        ' 
        ' buttonCloseReadingTag
        ' 
        buttonCloseReadingTag.FlatAppearance.BorderColor = Color.Black
        buttonCloseReadingTag.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
        buttonCloseReadingTag.FlatStyle = FlatStyle.Flat
        buttonCloseReadingTag.Image = CType(resources.GetObject("buttonCloseReadingTag.Image"), Image)
        buttonCloseReadingTag.Location = New Point(224, 5)
        buttonCloseReadingTag.Name = "buttonCloseReadingTag"
        buttonCloseReadingTag.Size = New Size(25, 23)
        buttonCloseReadingTag.TabIndex = 22
        buttonCloseReadingTag.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(80, 80)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(91, 72)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1119, 685)
        Controls.Add(LabelDateTime)
        Controls.Add(PictureBox1)
        Controls.Add(LabelConnectionStatus)
        Controls.Add(PanelMenu)
        Controls.Add(PanelRegistrationandEditUserData)
        Controls.Add(PanelUserData)
        Controls.Add(PanelConnection)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        Name = "Form1"
        Text = "G"
        UseWaitCursor = True
        PanelMenu.ResumeLayout(False)
        CType(PictureBoxSelect, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelConnection.ResumeLayout(False)
        PanelConnection.PerformLayout()
        PanelRegistrationandEditUserData.ResumeLayout(False)
        PanelRegistrationandEditUserData.PerformLayout()
        PanelReadingTagProcess.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBoxImagePreview, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(PictureBoxImageInput, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        PanelUserData.ResumeLayout(False)
        GroupBox.ResumeLayout(False)
        GroupBox.PerformLayout()
        GroupBoxImage.ResumeLayout(False)
        GroupBoxImage.PerformLayout()
        CType(PictureBoxUserImage, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents buttonConnection As Button
    Friend WithEvents buttonUserData As Button
    Friend WithEvents buttonRegistration As Button
    Friend WithEvents PictureBoxSelect As PictureBox
    Friend WithEvents LabelConnectionStatus As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents buttonScanPort As Button
    Friend WithEvents Label As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents buttonConnect As Button
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents LabelID As Label
    Friend WithEvents PictureBoxUserImage As PictureBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents labelnom As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelDep As Label
    Friend WithEvents buttonClear As Button
    Friend WithEvents labelville As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents labeladress As Label
    Friend WithEvents LabelDepartment As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents PanelRegistrationandEditUserData As Panel
    Friend WithEvents label1 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxadresse As TextBox
    Friend WithEvents TextBoxVille As TextBox
    Friend WithEvents TextBoxDep As TextBox
    Friend WithEvents buttonSave As Button
    Friend WithEvents buttonClearForm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents buttonScanID As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelGetID As Label
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents PictureBoxImagePreview As PictureBox
    Friend WithEvents PanelReadingTagProcess As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents buttonCloseReadingTag As Button
    Friend WithEvents PictureBox2 As PictureBox



End Class
