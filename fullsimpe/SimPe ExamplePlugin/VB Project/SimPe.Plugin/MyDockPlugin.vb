Imports Ambertation.Windows.Forms
Imports SimPe.Events
Imports SimPe.Interfaces
Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SimPe.Plugin
    Public Class MyDockPlugin
        Inherits DockPanel

        Implements IDockableTool, IToolExt, IToolPlugin

        ' Events
        Public Event ShowNewResource As ChangedResourceEvent Implements IDockableTool.ShowNewResource


        ' Methods
        Public Sub New()
            MyBase.CaptionText = "Example Dock"
            MyBase.ButtonText = "Example"
        End Sub

        Public Function GetDockableControl() As DockPanel Implements IDockableTool.GetDockableControl
            Return Me
        End Function

        Public Function ToString() As String Implements IToolPlugin.ToString
            Return MyBase.ToString()
        End Function

        Private Sub InitializeComponent()
            Me.label1 = New Label
            MyBase.SuspendLayout
            Me.label1.Dock = DockStyle.Fill
            Me.label1.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.label1.Location = New Point(0, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New Size(307, 468)
            Me.label1.TabIndex = 1
            Me.label1.Text = "This is an Example Dock"
            Me.label1.TextAlign = ContentAlignment.MiddleCenter
            MyBase.Controls.Add(Me.label1)
            MyBase.FloatingSize = New Size(319, 494)
            MyBase.Name = "MyDockPlugin"
            MyBase.Size = New Size(307, 468)
            MyBase.ResumeLayout(False)
        End Sub

        Public Sub RefreshDock(ByVal sender As Object, ByVal e As ResourceEventArgs) Implements IDockableTool.RefreshDock
            ' TODO: Implemet everything you need to react on selection/package changes in the SimPE GUI
        End Sub

        Public ReadOnly Property Visible() As Boolean Implements IToolExt.Visible
            Get
                Return MyBase.Visible
            End Get
        End Property


        ' Properties
        Public ReadOnly Property Icon() As Image Implements IToolExt.Icon
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property Shortcut() As Shortcut Implements IToolExt.Shortcut
            Get
                Return Shortcut.None
            End Get
        End Property


        ' Fields
        Private label1 As Label
    End Class
End Namespace


