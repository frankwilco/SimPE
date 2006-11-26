Imports SimPe.Interfaces.Plugin
Imports SimPe.Windows.Forms
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace SimPe.Plugin
    Public Class MyPackedFileUI
        Inherits WrapperBaseControl

        Implements IPackedFileUI, IDisposable

        ' Methods
        Private Sub InitializeComponent()
            Me.label1 = New Label
            MyBase.SuspendLayout
            Me.label1.AutoSize = True
            Me.label1.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.label1.Location = New Point(12, 34)
            Me.label1.Name = "label1"
            Me.label1.Size = New Size(139, 16)
            Me.label1.TabIndex = 1
            Me.label1.Text = "This is an Example"
            MyBase.Controls.Add(Me.label1)
            MyBase.HeaderText = "Example Wrapper"
            MyBase.Name = "MyPackedFileUI"
            MyBase.Controls.SetChildIndex(Me.label1, 0)
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout
        End Sub

        Public Overrides Sub OnCommit()
            MyBase.OnCommit
        End Sub

        Protected Overrides Sub RefreshGUI()
            MyBase.RefreshGUI
        End Sub

       

        


        ' Fields
        Private label1 As Label
    End Class
End Namespace


