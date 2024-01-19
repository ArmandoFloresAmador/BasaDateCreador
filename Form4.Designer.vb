<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PtxMinimizar = New System.Windows.Forms.PictureBox()
        Me.PtxCerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Imagen1 = New System.Windows.Forms.PictureBox()
        Me.Imagen2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagen2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.PtxMinimizar)
        Me.Panel1.Controls.Add(Me.PtxCerrar)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 38)
        Me.Panel1.TabIndex = 4
        '
        'PtxMinimizar
        '
        Me.PtxMinimizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.PtxMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxMinimizar.Image = CType(resources.GetObject("PtxMinimizar.Image"), System.Drawing.Image)
        Me.PtxMinimizar.Location = New System.Drawing.Point(239, 4)
        Me.PtxMinimizar.Name = "PtxMinimizar"
        Me.PtxMinimizar.Size = New System.Drawing.Size(34, 31)
        Me.PtxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxMinimizar.TabIndex = 2
        Me.PtxMinimizar.TabStop = False
        '
        'PtxCerrar
        '
        Me.PtxCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PtxCerrar.Image = CType(resources.GetObject("PtxCerrar.Image"), System.Drawing.Image)
        Me.PtxCerrar.Location = New System.Drawing.Point(279, 3)
        Me.PtxCerrar.Name = "PtxCerrar"
        Me.PtxCerrar.Size = New System.Drawing.Size(34, 32)
        Me.PtxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxCerrar.TabIndex = 0
        Me.PtxCerrar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña:"
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Text1.Location = New System.Drawing.Point(82, 139)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(226, 20)
        Me.Text1.TabIndex = 7
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(104, 195)
        Me.Text2.Name = "Text2"
        Me.Text2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text2.Size = New System.Drawing.Size(204, 20)
        Me.Text2.TabIndex = 8
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Chartreuse
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 275)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "No tengo cuenta"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.GreenYellow
        Me.LinkLabel2.Location = New System.Drawing.Point(183, 218)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(130, 13)
        Me.LinkLabel2.TabIndex = 10
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "¿Olvidaste la contraseña?"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'Imagen1
        '
        Me.Imagen1.Image = Global.AppArmando.My.Resources.Resources.ojo2
        Me.Imagen1.Location = New System.Drawing.Point(82, 195)
        Me.Imagen1.Name = "Imagen1"
        Me.Imagen1.Size = New System.Drawing.Size(25, 20)
        Me.Imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen1.TabIndex = 11
        Me.Imagen1.TabStop = False
        '
        'Imagen2
        '
        Me.Imagen2.Image = Global.AppArmando.My.Resources.Resources.ojo
        Me.Imagen2.Location = New System.Drawing.Point(82, 195)
        Me.Imagen2.Name = "Imagen2"
        Me.Imagen2.Size = New System.Drawing.Size(25, 20)
        Me.Imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen2.TabIndex = 12
        Me.Imagen2.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(325, 450)
        Me.Controls.Add(Me.Imagen2)
        Me.Controls.Add(Me.Imagen1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PtxMinimizar As PictureBox
    Friend WithEvents PtxCerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Imagen1 As PictureBox
    Friend WithEvents Imagen2 As PictureBox
End Class
