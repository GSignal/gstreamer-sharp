// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCRTPTransceiverDirectionGType))]
	public enum WebRTCRTPTransceiverDirection {

		None = 0,
		Inactive = 1,
		Sendonly = 2,
		Recvonly = 3,
		Sendrecv = 4,
	}

	internal class WebRTCRTPTransceiverDirectionGType {
		[DllImport ("libgstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_rtp_transceiver_direction_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_rtp_transceiver_direction_get_type ());
			}
		}
	}
#endregion
}
