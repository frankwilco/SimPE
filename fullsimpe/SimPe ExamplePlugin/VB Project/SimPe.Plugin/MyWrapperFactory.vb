Imports SimPe.Interfaces
Imports SimPe.Interfaces.Plugin
Imports System

Namespace SimPe.Plugin
    Public Class MyWrapperFactory
        Inherits AbstractWrapperFactory

        Implements IToolFactory, IWrapperFactory


        ' Methods
        Private ReadOnly Property FileName() As String Implements IToolFactory.FileName
            Get
                Return MyBase.FileName
            End Get
        End Property


        ' Properties
        Public ReadOnly Property KnownTools() As IToolPlugin() Implements IToolFactory.KnownTools
            Get
                Return New IToolPlugin() {New MyWindowPlugin, New MyDockPlugin}
            End Get
        End Property

        Public Overrides ReadOnly Property KnownWrappers() As IWrapper() Implements IWrapperFactory.KnownWrappers
            Get
                Return New IWrapper() {New MyPackedFileWrapper}
            End Get
        End Property

        Public Property LinkedProvider1() As Interfaces.IProviderRegistry Implements Interfaces.Plugin.IToolFactory.LinkedProvider
            Get

            End Get
            Set(ByVal value As Interfaces.IProviderRegistry)

            End Set
        End Property

        Public Property LinkedRegistry1() As Interfaces.IWrapperRegistry Implements Interfaces.Plugin.IToolFactory.LinkedRegistry
            Get

            End Get
            Set(ByVal value As Interfaces.IWrapperRegistry)

            End Set
        End Property
    End Class
End Namespace


