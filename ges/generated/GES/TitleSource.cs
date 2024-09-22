// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TitleSource : GES.VideoSource {

		public TitleSource (IntPtr raw) : base(raw) {}

		protected TitleSource() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_ges_reserved"
							, GES.VideoSource.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 3 // _ges_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_title_source_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_title_source_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint ges_title_source_get_background_color(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_background_color(IntPtr raw, uint color);

		public uint BackgroundColor { 
			get {
				uint raw_ret = ges_title_source_get_background_color(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set {
				ges_title_source_set_background_color(Handle, value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_title_source_get_font_desc(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_font_desc(IntPtr raw, IntPtr font_desc);

		[Obsolete]
		public string FontDesc { 
			get {
				IntPtr raw_ret = ges_title_source_get_font_desc(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				ges_title_source_set_font_desc(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_title_source_get_halignment(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_halignment(IntPtr raw, int halign);

		public GES.TextHAlign Halignment { 
			get {
				int raw_ret = ges_title_source_get_halignment(Handle);
				GES.TextHAlign ret = (GES.TextHAlign) raw_ret;
				return ret;
			}
			set {
				ges_title_source_set_halignment(Handle, (int) value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_title_source_get_text(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_text(IntPtr raw, IntPtr text);

		[Obsolete]
		public string Text { 
			get {
				IntPtr raw_ret = ges_title_source_get_text(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				ges_title_source_set_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint ges_title_source_get_text_color(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_text_color(IntPtr raw, uint color);

		public uint TextColor { 
			get {
				uint raw_ret = ges_title_source_get_text_color(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set {
				ges_title_source_set_text_color(Handle, value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_title_source_get_valignment(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_valignment(IntPtr raw, int valign);

		public GES.TextVAlign Valignment { 
			get {
				int raw_ret = ges_title_source_get_valignment(Handle);
				GES.TextVAlign ret = (GES.TextVAlign) raw_ret;
				return ret;
			}
			set {
				ges_title_source_set_valignment(Handle, (int) value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double ges_title_source_get_xpos(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_xpos(IntPtr raw, double position);

		public double Xpos { 
			get {
				double raw_ret = ges_title_source_get_xpos(Handle);
				double ret = raw_ret;
				return ret;
			}
			set {
				ges_title_source_set_xpos(Handle, value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double ges_title_source_get_ypos(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_title_source_set_ypos(IntPtr raw, double position);

		public double Ypos { 
			get {
				double raw_ret = ges_title_source_get_ypos(Handle);
				double ret = raw_ret;
				return ret;
			}
			set {
				ges_title_source_set_ypos(Handle, value);
			}
		}


		static TitleSource ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GES.VideoSource.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
