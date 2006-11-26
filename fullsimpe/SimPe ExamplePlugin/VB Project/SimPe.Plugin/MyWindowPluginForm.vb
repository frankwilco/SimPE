Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace SimPe.Plugin
    Public Class MyWindowPluginForm
        Inherits Form

        ' Methods
        Public Sub New()
            Me.components = Nothing
            Me.InitializeComponent
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.label1 = New Label
            MyBase.SuspendLayout
            Me.label1.AutoSize = True
            Me.label1.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.label1.Location = New Point(62, 125)
            Me.label1.Name = "label1"
            Me.label1.Size = New Size(169, 16)
            Me.label1.TabIndex = 0
            Me.label1.Text = "This is an Example GUI"
            MyBase.AutoScaleDimensions = New SizeF(6!, 13!)
            MyBase.AutoScaleMode = AutoScaleMode.Font
            MyBase.ClientSize = New Size(292, 266)
            MyBase.Controls.Add(Me.label1)
            MyBase.FormBorderStyle = FormBorderStyle.SizableToolWindow
            MyBase.Name = "MyWindowPluginForm"
            Me.Text = "Example Window Plugin"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout
        End Sub


        ' Fields
        Private components As IContainer
        Private label1 As Label
    End Class
End Namespace


