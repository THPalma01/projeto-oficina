<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastrar_Clientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastrar_Clientes))
        Me.Panel_Lateral = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.Label()
        Me.btn_veiculos = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_ajuda = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_orcamentos = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_visu_clientes = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Header = New System.Windows.Forms.Panel()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.btn_return = New Guna.UI.WinForms.GunaImageButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.btn_excluir = New Guna.UI.WinForms.GunaCircleButton()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.btn_editar = New Guna.UI.WinForms.GunaCircleButton()
        Me.txt_telefone = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btn_salvar = New Guna.UI.WinForms.GunaCircleButton()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.txt_email = New Guna.UI.WinForms.GunaLineTextBox()
        Me.BunifuCustomLatbel2 = New ns1.BunifuCustomLabel()
        Me.txt_cpf = New Guna.UI.WinForms.GunaLineTextBox()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.txt_cliente = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Panel_Lateral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Lateral
        '
        Me.Panel_Lateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_Lateral.Controls.Add(Me.Panel5)
        Me.Panel_Lateral.Controls.Add(Me.Panel1)
        Me.Panel_Lateral.Controls.Add(Me.btn_veiculos)
        Me.Panel_Lateral.Controls.Add(Me.btn_ajuda)
        Me.Panel_Lateral.Controls.Add(Me.btn_orcamentos)
        Me.Panel_Lateral.Controls.Add(Me.btn_visu_clientes)
        Me.Panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Lateral.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Lateral.Name = "Panel_Lateral"
        Me.Panel_Lateral.Size = New System.Drawing.Size(271, 555)
        Me.Panel_Lateral.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 473)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(271, 82)
        Me.Panel5.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 100)
        Me.Panel1.TabIndex = 8
        '
        'logo
        '
        Me.logo.AutoSize = True
        Me.logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo.Font = New System.Drawing.Font("Century Gothic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(194, 84)
        Me.logo.TabIndex = 3
        Me.logo.Text = "Cadastrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clientes"
        '
        'btn_veiculos
        '
        Me.btn_veiculos.AnimationHoverSpeed = 0.07!
        Me.btn_veiculos.AnimationSpeed = 0.03!
        Me.btn_veiculos.BackColor = System.Drawing.Color.Transparent
        Me.btn_veiculos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_veiculos.BorderColor = System.Drawing.Color.Black
        Me.btn_veiculos.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_veiculos.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_veiculos.CheckedForeColor = System.Drawing.Color.White
        Me.btn_veiculos.CheckedImage = CType(resources.GetObject("btn_veiculos.CheckedImage"), System.Drawing.Image)
        Me.btn_veiculos.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_veiculos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_veiculos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_veiculos.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_veiculos.ForeColor = System.Drawing.Color.White
        Me.btn_veiculos.Image = CType(resources.GetObject("btn_veiculos.Image"), System.Drawing.Image)
        Me.btn_veiculos.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_veiculos.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_veiculos.Location = New System.Drawing.Point(0, 230)
        Me.btn_veiculos.Name = "btn_veiculos"
        Me.btn_veiculos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_veiculos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_veiculos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_veiculos.OnHoverImage = Nothing
        Me.btn_veiculos.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_veiculos.OnPressedColor = System.Drawing.Color.Black
        Me.btn_veiculos.Radius = 10
        Me.btn_veiculos.Size = New System.Drawing.Size(269, 49)
        Me.btn_veiculos.TabIndex = 7
        Me.btn_veiculos.Text = "Ir para veículos"
        Me.btn_veiculos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ajuda
        '
        Me.btn_ajuda.AnimationHoverSpeed = 0.07!
        Me.btn_ajuda.AnimationSpeed = 0.03!
        Me.btn_ajuda.BackColor = System.Drawing.Color.Transparent
        Me.btn_ajuda.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ajuda.BorderColor = System.Drawing.Color.Black
        Me.btn_ajuda.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_ajuda.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_ajuda.CheckedForeColor = System.Drawing.Color.White
        Me.btn_ajuda.CheckedImage = CType(resources.GetObject("btn_ajuda.CheckedImage"), System.Drawing.Image)
        Me.btn_ajuda.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_ajuda.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_ajuda.FocusedColor = System.Drawing.Color.Empty
        Me.btn_ajuda.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ajuda.ForeColor = System.Drawing.Color.White
        Me.btn_ajuda.Image = CType(resources.GetObject("btn_ajuda.Image"), System.Drawing.Image)
        Me.btn_ajuda.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_ajuda.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ajuda.Location = New System.Drawing.Point(0, 374)
        Me.btn_ajuda.Name = "btn_ajuda"
        Me.btn_ajuda.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ajuda.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_ajuda.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_ajuda.OnHoverImage = Nothing
        Me.btn_ajuda.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ajuda.OnPressedColor = System.Drawing.Color.Black
        Me.btn_ajuda.Radius = 10
        Me.btn_ajuda.Size = New System.Drawing.Size(268, 49)
        Me.btn_ajuda.TabIndex = 6
        Me.btn_ajuda.Text = "Ajuda"
        Me.btn_ajuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_orcamentos
        '
        Me.btn_orcamentos.AnimationHoverSpeed = 0.07!
        Me.btn_orcamentos.AnimationSpeed = 0.03!
        Me.btn_orcamentos.BackColor = System.Drawing.Color.Transparent
        Me.btn_orcamentos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_orcamentos.BorderColor = System.Drawing.Color.Black
        Me.btn_orcamentos.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_orcamentos.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_orcamentos.CheckedForeColor = System.Drawing.Color.White
        Me.btn_orcamentos.CheckedImage = CType(resources.GetObject("btn_orcamentos.CheckedImage"), System.Drawing.Image)
        Me.btn_orcamentos.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_orcamentos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_orcamentos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_orcamentos.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_orcamentos.ForeColor = System.Drawing.Color.White
        Me.btn_orcamentos.Image = CType(resources.GetObject("btn_orcamentos.Image"), System.Drawing.Image)
        Me.btn_orcamentos.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_orcamentos.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_orcamentos.Location = New System.Drawing.Point(3, 303)
        Me.btn_orcamentos.Name = "btn_orcamentos"
        Me.btn_orcamentos.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_orcamentos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_orcamentos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_orcamentos.OnHoverImage = Nothing
        Me.btn_orcamentos.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_orcamentos.OnPressedColor = System.Drawing.Color.Black
        Me.btn_orcamentos.Radius = 10
        Me.btn_orcamentos.Size = New System.Drawing.Size(265, 49)
        Me.btn_orcamentos.TabIndex = 5
        Me.btn_orcamentos.Text = "Ir para orçamento"
        Me.btn_orcamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_visu_clientes
        '
        Me.btn_visu_clientes.AnimationHoverSpeed = 0.07!
        Me.btn_visu_clientes.AnimationSpeed = 0.03!
        Me.btn_visu_clientes.BackColor = System.Drawing.Color.Transparent
        Me.btn_visu_clientes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_visu_clientes.BorderColor = System.Drawing.Color.Black
        Me.btn_visu_clientes.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_visu_clientes.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_visu_clientes.CheckedForeColor = System.Drawing.Color.White
        Me.btn_visu_clientes.CheckedImage = CType(resources.GetObject("btn_visu_clientes.CheckedImage"), System.Drawing.Image)
        Me.btn_visu_clientes.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_visu_clientes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_visu_clientes.FocusedColor = System.Drawing.Color.Empty
        Me.btn_visu_clientes.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_visu_clientes.ForeColor = System.Drawing.Color.White
        Me.btn_visu_clientes.Image = CType(resources.GetObject("btn_visu_clientes.Image"), System.Drawing.Image)
        Me.btn_visu_clientes.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_visu_clientes.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_visu_clientes.Location = New System.Drawing.Point(3, 161)
        Me.btn_visu_clientes.Name = "btn_visu_clientes"
        Me.btn_visu_clientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_visu_clientes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_visu_clientes.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_visu_clientes.OnHoverImage = Nothing
        Me.btn_visu_clientes.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_visu_clientes.OnPressedColor = System.Drawing.Color.Black
        Me.btn_visu_clientes.Radius = 10
        Me.btn_visu_clientes.Size = New System.Drawing.Size(265, 49)
        Me.btn_visu_clientes.TabIndex = 4
        Me.btn_visu_clientes.Text = "Visualizar Clientes"
        Me.btn_visu_clientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header.Controls.Add(Me.GunaImageButton2)
        Me.Header.Controls.Add(Me.btn_return)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(271, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(651, 100)
        Me.Header.TabIndex = 9
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaImageButton2.Image = CType(resources.GetObject("GunaImageButton2.Image"), System.Drawing.Image)
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton2.Location = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(78, 100)
        Me.GunaImageButton2.TabIndex = 1
        '
        'btn_return
        '
        Me.btn_return.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_return.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_return.Location = New System.Drawing.Point(576, 0)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.OnHoverImage = Nothing
        Me.btn_return.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_return.Size = New System.Drawing.Size(75, 100)
        Me.btn_return.TabIndex = 0
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Nothing
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(271, 473)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(651, 82)
        Me.Panel3.TabIndex = 12
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.btn_excluir)
        Me.GunaGradient2Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GunaGradient2Panel1.Controls.Add(Me.btn_editar)
        Me.GunaGradient2Panel1.Controls.Add(Me.txt_telefone)
        Me.GunaGradient2Panel1.Controls.Add(Me.btn_salvar)
        Me.GunaGradient2Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GunaGradient2Panel1.Controls.Add(Me.txt_email)
        Me.GunaGradient2Panel1.Controls.Add(Me.BunifuCustomLatbel2)
        Me.GunaGradient2Panel1.Controls.Add(Me.txt_cpf)
        Me.GunaGradient2Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GunaGradient2Panel1.Controls.Add(Me.txt_cliente)
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(922, 555)
        Me.GunaGradient2Panel1.TabIndex = 13
        '
        'btn_excluir
        '
        Me.btn_excluir.Animated = True
        Me.btn_excluir.AnimationHoverSpeed = 0.07!
        Me.btn_excluir.AnimationSpeed = 0.03!
        Me.btn_excluir.BaseColor = System.Drawing.Color.Transparent
        Me.btn_excluir.BorderColor = System.Drawing.Color.Black
        Me.btn_excluir.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_excluir.FocusedColor = System.Drawing.Color.Empty
        Me.btn_excluir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_excluir.ForeColor = System.Drawing.Color.White
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_excluir.Location = New System.Drawing.Point(812, 374)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_excluir.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_excluir.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_excluir.OnHoverImage = Nothing
        Me.btn_excluir.OnPressedColor = System.Drawing.Color.Black
        Me.btn_excluir.Size = New System.Drawing.Size(98, 82)
        Me.btn_excluir.TabIndex = 11
        Me.btn_excluir.Text = "Excluir"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(277, 222)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(119, 28)
        Me.BunifuCustomLabel4.TabIndex = 9
        Me.BunifuCustomLabel4.Text = "TELEFONE"
        '
        'btn_editar
        '
        Me.btn_editar.Animated = True
        Me.btn_editar.AnimationHoverSpeed = 0.07!
        Me.btn_editar.AnimationSpeed = 0.03!
        Me.btn_editar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_editar.BorderColor = System.Drawing.Color.Black
        Me.btn_editar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_editar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_editar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_editar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_editar.Location = New System.Drawing.Point(812, 273)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_editar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_editar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_editar.OnHoverImage = Nothing
        Me.btn_editar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_editar.Size = New System.Drawing.Size(98, 79)
        Me.btn_editar.TabIndex = 12
        Me.btn_editar.Text = "Editar"
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.Color.White
        Me.txt_telefone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_telefone.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_telefone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_telefone.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txt_telefone.Location = New System.Drawing.Point(282, 253)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_telefone.SelectedText = ""
        Me.txt_telefone.Size = New System.Drawing.Size(406, 26)
        Me.txt_telefone.TabIndex = 8
        '
        'btn_salvar
        '
        Me.btn_salvar.Animated = True
        Me.btn_salvar.AnimationHoverSpeed = 0.07!
        Me.btn_salvar.AnimationSpeed = 0.03!
        Me.btn_salvar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BorderColor = System.Drawing.Color.Black
        Me.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_salvar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_salvar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_salvar.Location = New System.Drawing.Point(812, 174)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_salvar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_salvar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_salvar.OnHoverImage = Nothing
        Me.btn_salvar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_salvar.Size = New System.Drawing.Size(98, 76)
        Me.btn_salvar.TabIndex = 10
        Me.btn_salvar.Text = "Salvar"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(277, 374)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(82, 28)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "EMAIL"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(282, 405)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(406, 26)
        Me.txt_email.TabIndex = 6
        '
        'BunifuCustomLatbel2
        '
        Me.BunifuCustomLatbel2.AutoSize = True
        Me.BunifuCustomLatbel2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLatbel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLatbel2.Location = New System.Drawing.Point(277, 295)
        Me.BunifuCustomLatbel2.Name = "BunifuCustomLatbel2"
        Me.BunifuCustomLatbel2.Size = New System.Drawing.Size(56, 28)
        Me.BunifuCustomLatbel2.TabIndex = 5
        Me.BunifuCustomLatbel2.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.White
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpf.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(282, 326)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.Size = New System.Drawing.Size(406, 26)
        Me.txt_cpf.TabIndex = 4
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(277, 153)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(224, 28)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "NOME DO CLIENTE"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.Color.White
        Me.txt_cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cliente.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cliente.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txt_cliente.Location = New System.Drawing.Point(282, 184)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cliente.SelectedText = ""
        Me.txt_cliente.Size = New System.Drawing.Size(406, 26)
        Me.txt_cliente.TabIndex = 2
        '
        'Cadastrar_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(922, 555)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Panel_Lateral)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cadastrar_Clientes"
        Me.Text = "Cadastrar_Clientes"
        Me.Panel_Lateral.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Header.ResumeLayout(False)
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Lateral As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents logo As Label
    Friend WithEvents btn_visu_clientes As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_veiculos As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_ajuda As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_orcamentos As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btn_return As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents txt_cliente As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btn_editar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_excluir As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_salvar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents txt_telefone As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents txt_email As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BunifuCustomLatbel2 As ns1.BunifuCustomLabel
    Friend WithEvents txt_cpf As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
End Class
