<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantsViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbLayers = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnRestaurants = New System.Windows.Forms.Button()
        Me.btnBars = New System.Windows.Forms.Button()
        Me.btnLounges = New System.Windows.Forms.Button()
        Me.btnDiners = New System.Windows.Forms.Button()
        Me.btnCafes = New System.Windows.Forms.Button()
        Me.cmbVenues = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbLayers
        '
        Me.cmbLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayers.FormattingEnabled = True
        Me.cmbLayers.Location = New System.Drawing.Point(101, 40)
        Me.cmbLayers.Name = "cmbLayers"
        Me.cmbLayers.Size = New System.Drawing.Size(194, 21)
        Me.cmbLayers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Layers"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(323, 40)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(419, 40)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 3
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnRestaurants
        '
        Me.btnRestaurants.Location = New System.Drawing.Point(32, 135)
        Me.btnRestaurants.Name = "btnRestaurants"
        Me.btnRestaurants.Size = New System.Drawing.Size(75, 23)
        Me.btnRestaurants.TabIndex = 4
        Me.btnRestaurants.Tag = "1"
        Me.btnRestaurants.Text = "Restaurants"
        Me.btnRestaurants.UseVisualStyleBackColor = True
        '
        'btnBars
        '
        Me.btnBars.Location = New System.Drawing.Point(113, 135)
        Me.btnBars.Name = "btnBars"
        Me.btnBars.Size = New System.Drawing.Size(75, 23)
        Me.btnBars.TabIndex = 5
        Me.btnBars.Tag = "3"
        Me.btnBars.Text = "Bars"
        Me.btnBars.UseVisualStyleBackColor = True
        '
        'btnLounges
        '
        Me.btnLounges.Location = New System.Drawing.Point(194, 135)
        Me.btnLounges.Name = "btnLounges"
        Me.btnLounges.Size = New System.Drawing.Size(75, 23)
        Me.btnLounges.TabIndex = 6
        Me.btnLounges.Tag = "4"
        Me.btnLounges.Text = "Lounges"
        Me.btnLounges.UseVisualStyleBackColor = True
        '
        'btnDiners
        '
        Me.btnDiners.Location = New System.Drawing.Point(275, 135)
        Me.btnDiners.Name = "btnDiners"
        Me.btnDiners.Size = New System.Drawing.Size(75, 23)
        Me.btnDiners.TabIndex = 7
        Me.btnDiners.Tag = "0"
        Me.btnDiners.Text = "Diners"
        Me.btnDiners.UseVisualStyleBackColor = True
        '
        'btnCafes
        '
        Me.btnCafes.Location = New System.Drawing.Point(356, 135)
        Me.btnCafes.Name = "btnCafes"
        Me.btnCafes.Size = New System.Drawing.Size(75, 23)
        Me.btnCafes.TabIndex = 8
        Me.btnCafes.Tag = "2"
        Me.btnCafes.Text = "Cafes"
        Me.btnCafes.UseVisualStyleBackColor = True
        '
        'cmbVenues
        '
        Me.cmbVenues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVenues.FormattingEnabled = True
        Me.cmbVenues.Location = New System.Drawing.Point(101, 79)
        Me.cmbVenues.Name = "cmbVenues"
        Me.cmbVenues.Size = New System.Drawing.Size(194, 21)
        Me.cmbVenues.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Venues"
        '
        'frmRestaurantsViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 262)
        Me.Controls.Add(Me.cmbVenues)
        Me.Controls.Add(Me.btnCafes)
        Me.Controls.Add(Me.btnDiners)
        Me.Controls.Add(Me.btnLounges)
        Me.Controls.Add(Me.btnBars)
        Me.Controls.Add(Me.btnRestaurants)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLayers)
        Me.Name = "frmRestaurantsViewer"
        Me.Text = "frmRestaurantsViewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbLayers As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnRestaurants As System.Windows.Forms.Button
    Friend WithEvents btnBars As System.Windows.Forms.Button
    Friend WithEvents btnLounges As System.Windows.Forms.Button
    Friend WithEvents btnDiners As System.Windows.Forms.Button
    Friend WithEvents btnCafes As System.Windows.Forms.Button
    Friend WithEvents cmbVenues As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
