Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class sox_effect_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As sox_effect_t) As HandleRef
            Return If(obj Is Nothing, New HandleRef(Nothing, IntPtr.Zero), obj.swigCPtr)
        End Function

        Protected Overrides Sub Finalize()
            Dispose()
        End Sub

        Public Overridable Sub Dispose() Implements IDisposable.Dispose
            SyncLock Me
                If swigCPtr.Handle <> IntPtr.Zero Then
                    If swigCMemOwn Then
                        swigCMemOwn = False
                        libsoxPINVOKE.delete_sox_effect_t(swigCPtr)
                    End If
                    swigCPtr = New HandleRef(Nothing, IntPtr.Zero)
                End If
                GC.SuppressFinalize(Me)
            End SyncLock
        End Sub

        Public Sub New(ByVal cPtr As IntPtr)
            swigCMemOwn = False
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Public Function GetswigCPtr() As IntPtr
            Return swigCPtr.Handle
        End Function


        Public Property global_info() As sox_effects_globals_t
            Set(ByVal value As sox_effects_globals_t)
                libsoxPINVOKE.sox_effect_t_global_info_set(swigCPtr, sox_effects_globals_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_global_info_get(swigCPtr)
                Dim ret As sox_effects_globals_t = If(cPtr = IntPtr.Zero, Nothing, New sox_effects_globals_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property in_signal() As sox_signalinfo_t
            Set(ByVal value As sox_signalinfo_t)
                libsoxPINVOKE.sox_effect_t_in_signal_set(swigCPtr, sox_signalinfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_in_signal_get(swigCPtr)
                Dim ret As sox_signalinfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_signalinfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property out_signal() As sox_signalinfo_t
            Set(ByVal value As sox_signalinfo_t)
                libsoxPINVOKE.sox_effect_t_out_signal_set(swigCPtr, sox_signalinfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_out_signal_get(swigCPtr)
                Dim ret As sox_signalinfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_signalinfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property in_encoding() As sox_encodinginfo_t
            Set(ByVal value As sox_encodinginfo_t)
                libsoxPINVOKE.sox_effect_t_in_encoding_set(swigCPtr, sox_encodinginfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_in_encoding_get(swigCPtr)
                Dim ret As sox_encodinginfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_encodinginfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property out_encoding() As sox_encodinginfo_t
            Set(ByVal value As sox_encodinginfo_t)
                libsoxPINVOKE.sox_effect_t_out_encoding_set(swigCPtr, sox_encodinginfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_out_encoding_get(swigCPtr)
                Dim ret As sox_encodinginfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_encodinginfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property handler() As SWIGTYPE_p_sox_effect_handler_t
            Set(ByVal value As SWIGTYPE_p_sox_effect_handler_t)
                libsoxPINVOKE.sox_effect_t_handler_set(swigCPtr, SWIGTYPE_p_sox_effect_handler_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_handler_get(swigCPtr)
                Dim ret As SWIGTYPE_p_sox_effect_handler_t = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_sox_effect_handler_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property obuf() As SWIGTYPE_p_int
            Set(ByVal value As SWIGTYPE_p_int)
                libsoxPINVOKE.sox_effect_t_obuf_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_obuf_get(swigCPtr)
                Dim ret As SWIGTYPE_p_int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property obeg() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effect_t_obeg_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effect_t_obeg_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property oend() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effect_t_oend_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effect_t_oend_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property imin() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effect_t_imin_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effect_t_imin_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property clips() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effect_t_clips_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effect_t_clips_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property flows() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effect_t_flows_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effect_t_flows_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property flow() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_effect_t_flow_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_effect_t_flow_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property priv() As SWIGTYPE_p_void
            Set(ByVal value As SWIGTYPE_p_void)
                libsoxPINVOKE.sox_effect_t_priv_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_effect_t_priv_get(swigCPtr)
                Dim ret As SWIGTYPE_p_void = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_void(cPtr, False))
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_sox_effect_t(), True)
        End Sub

    End Class

End Namespace
