// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Buffer : Gst.MiniObject {

		public Gst.BufferPool Pool {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("pool"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.BufferPool;
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("pool"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public ulong Pts {
			get {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("pts"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("pts"));
					*raw_ptr = value;
				}
			}
		}

		public ulong Dts {
			get {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("dts"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("dts"));
					*raw_ptr = value;
				}
			}
		}

		public ulong Duration {
			get {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("duration"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("duration"));
					*raw_ptr = value;
				}
			}
		}

		public ulong Offset {
			get {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("offset"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("offset"));
					*raw_ptr = value;
				}
			}
		}

		public ulong OffsetEnd {
			get {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("offset_end"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("offset_end"));
					*raw_ptr = value;
				}
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_buffer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_add_custom_meta(IntPtr raw, IntPtr name);

		public Gst.CustomMeta AddCustomMeta(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_buffer_add_custom_meta(Handle, native_name);
			Gst.CustomMeta ret = Gst.CustomMeta.New (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_add_meta(IntPtr raw, IntPtr info, IntPtr parms);

		public Gst.Meta AddMeta(Gst.MetaInfo info, IntPtr parms) {
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			IntPtr raw_ret = gst_buffer_add_meta(Handle, native_info, parms);
			Gst.Meta ret = Gst.Meta.New (raw_ret);
			Marshal.FreeHGlobal (native_info);
			return ret;
		}

		public Gst.Meta AddMeta(Gst.MetaInfo info) {
			return AddMeta (info, IntPtr.Zero);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_add_parent_buffer_meta(IntPtr raw, IntPtr reference);

		public Gst.ParentBufferMeta AddParentBufferMeta(Gst.Buffer reference) {
			IntPtr raw_ret = gst_buffer_add_parent_buffer_meta(Handle, reference == null ? IntPtr.Zero : reference.Handle);
			Gst.ParentBufferMeta ret = Gst.ParentBufferMeta.New (raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_add_protection_meta(IntPtr raw, IntPtr info);

		public Gst.ProtectionMeta AddProtectionMeta(Gst.Structure info) {
			info.Owned = false;
			IntPtr raw_ret = gst_buffer_add_protection_meta(Handle, info == null ? IntPtr.Zero : info.Handle);
			Gst.ProtectionMeta ret = Gst.ProtectionMeta.New (raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_add_reference_timestamp_meta(IntPtr raw, IntPtr reference, ulong timestamp, ulong duration);

		public Gst.ReferenceTimestampMeta AddReferenceTimestampMeta(Gst.Caps reference, ulong timestamp, ulong duration) {
			IntPtr raw_ret = gst_buffer_add_reference_timestamp_meta(Handle, reference == null ? IntPtr.Zero : reference.Handle, timestamp, duration);
			Gst.ReferenceTimestampMeta ret = Gst.ReferenceTimestampMeta.New (raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_append(IntPtr raw, IntPtr buf2);

		public Gst.Buffer Append(Gst.Buffer buf2) {
			buf2.Owned = false;
			IntPtr raw_ret = gst_buffer_append(Handle, buf2 == null ? IntPtr.Zero : buf2.Handle);
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_append_memory(IntPtr raw, IntPtr mem);

		public void AppendMemory(Gst.Memory mem) {
			mem.Owned = false;
			gst_buffer_append_memory(Handle, mem == null ? IntPtr.Zero : mem.Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_append_region(IntPtr raw, IntPtr buf2, IntPtr offset, IntPtr size);

		public Gst.Buffer AppendRegion(Gst.Buffer buf2, long offset, long size) {
			buf2.Owned = false;
			IntPtr raw_ret = gst_buffer_append_region(Handle, buf2 == null ? IntPtr.Zero : buf2.Handle, new IntPtr (offset), new IntPtr (size));
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_copy_deep(IntPtr raw);

		public Gst.Buffer CopyDeep() {
			IntPtr raw_ret = gst_buffer_copy_deep(Handle);
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_copy_into(IntPtr raw, IntPtr src, int flags, UIntPtr offset, UIntPtr size);

		public bool CopyInto(Gst.Buffer src, Gst.BufferCopyFlags flags, ulong offset, ulong size) {
			bool raw_ret = gst_buffer_copy_into(Handle, src == null ? IntPtr.Zero : src.Handle, (int) flags, new UIntPtr (offset), new UIntPtr (size));
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_copy_region(IntPtr raw, int flags, UIntPtr offset, UIntPtr size);

		public Gst.Buffer CopyRegion(Gst.BufferCopyFlags flags, ulong offset, ulong size) {
			IntPtr raw_ret = gst_buffer_copy_region(Handle, (int) flags, new UIntPtr (offset), new UIntPtr (size));
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_buffer_fill(IntPtr raw, UIntPtr offset, byte[] src, UIntPtr n_length);

		public ulong Fill(ulong offset, byte[] src) {
			UIntPtr raw_ret = gst_buffer_fill(Handle, new UIntPtr (offset), src, new UIntPtr ((ulong) (src == null ? 0 : src.Length)));
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_find_memory(IntPtr raw, UIntPtr offset, UIntPtr size, out uint idx, out uint length, out UIntPtr skip);

		public bool FindMemory(ulong offset, ulong size, out uint idx, out uint length, out ulong skip) {
			UIntPtr native_skip;
			bool raw_ret = gst_buffer_find_memory(Handle, new UIntPtr (offset), new UIntPtr (size), out idx, out length, out native_skip);
			bool ret = raw_ret;
			skip = (ulong) native_skip;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_all_memory(IntPtr raw);

		public Gst.Memory AllMemory { 
			get {
				IntPtr raw_ret = gst_buffer_get_all_memory(Handle);
				Gst.Memory ret = raw_ret == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Memory), true);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_custom_meta(IntPtr raw, IntPtr name);

		public Gst.CustomMeta GetCustomMeta(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_buffer_get_custom_meta(Handle, native_name);
			Gst.CustomMeta ret = Gst.CustomMeta.New (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_buffer_get_flags(IntPtr raw);

		public Gst.BufferFlags Flags { 
			get {
				int raw_ret = gst_buffer_get_flags(Handle);
				Gst.BufferFlags ret = (Gst.BufferFlags) raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_memory(IntPtr raw, uint idx);

		public Gst.Memory GetMemory(uint idx) {
			IntPtr raw_ret = gst_buffer_get_memory(Handle, idx);
			Gst.Memory ret = raw_ret == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Memory), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_memory_range(IntPtr raw, uint idx, int length);

		public Gst.Memory GetMemoryRange(uint idx, int length) {
			IntPtr raw_ret = gst_buffer_get_memory_range(Handle, idx, length);
			Gst.Memory ret = raw_ret == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Memory), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_meta(IntPtr raw, IntPtr api);

		public Gst.Meta GetMeta(GLib.GType api) {
			IntPtr raw_ret = gst_buffer_get_meta(Handle, api.Val);
			Gst.Meta ret = Gst.Meta.New (raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_buffer_get_n_meta(IntPtr raw, IntPtr api_type);

		public uint GetNMeta(GLib.GType api_type) {
			uint raw_ret = gst_buffer_get_n_meta(Handle, api_type.Val);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_reference_timestamp_meta(IntPtr raw, IntPtr reference);

		public Gst.ReferenceTimestampMeta GetReferenceTimestampMeta(Gst.Caps reference) {
			IntPtr raw_ret = gst_buffer_get_reference_timestamp_meta(Handle, reference == null ? IntPtr.Zero : reference.Handle);
			Gst.ReferenceTimestampMeta ret = Gst.ReferenceTimestampMeta.New (raw_ret);
			return ret;
		}

		public Gst.ReferenceTimestampMeta GetReferenceTimestampMeta() {
			return GetReferenceTimestampMeta (null);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_buffer_get_size(IntPtr raw);

		public ulong Size { 
			get {
				UIntPtr raw_ret = gst_buffer_get_size(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_buffer_get_sizes(IntPtr raw, out UIntPtr offset, out UIntPtr maxsize);

		public ulong GetSizes(out ulong offset, out ulong maxsize) {
			UIntPtr native_offset;
			UIntPtr native_maxsize;
			UIntPtr raw_ret = gst_buffer_get_sizes(Handle, out native_offset, out native_maxsize);
			ulong ret = (ulong) raw_ret;
			offset = (ulong) native_offset;
			maxsize = (ulong) native_maxsize;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_buffer_get_sizes_range(IntPtr raw, uint idx, int length, out UIntPtr offset, out UIntPtr maxsize);

		public ulong GetSizesRange(uint idx, int length, out ulong offset, out ulong maxsize) {
			UIntPtr native_offset;
			UIntPtr native_maxsize;
			UIntPtr raw_ret = gst_buffer_get_sizes_range(Handle, idx, length, out native_offset, out native_maxsize);
			ulong ret = (ulong) raw_ret;
			offset = (ulong) native_offset;
			maxsize = (ulong) native_maxsize;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_has_flags(IntPtr raw, int flags);

		public bool HasFlags(Gst.BufferFlags flags) {
			bool raw_ret = gst_buffer_has_flags(Handle, (int) flags);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_insert_memory(IntPtr raw, int idx, IntPtr mem);

		public void InsertMemory(int idx, Gst.Memory mem) {
			mem.Owned = false;
			gst_buffer_insert_memory(Handle, idx, mem == null ? IntPtr.Zero : mem.Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_is_all_memory_writable(IntPtr raw);

		public bool IsAllMemoryWritable { 
			get {
				bool raw_ret = gst_buffer_is_all_memory_writable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_is_memory_range_writable(IntPtr raw, uint idx, int length);

		public bool IsMemoryRangeWritable(uint idx, int length) {
			bool raw_ret = gst_buffer_is_memory_range_writable(Handle, idx, length);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_map(IntPtr raw, IntPtr info, int flags);

		public bool Map(out Gst.MapInfo info, Gst.MapFlags flags) {
			IntPtr native_info = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.MapInfo)));
			bool raw_ret = gst_buffer_map(Handle, native_info, (int) flags);
			bool ret = raw_ret;
			info = Gst.MapInfo.New (native_info);
			Marshal.FreeHGlobal (native_info);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_map_range(IntPtr raw, uint idx, int length, IntPtr info, int flags);

		public bool MapRange(uint idx, int length, out Gst.MapInfo info, Gst.MapFlags flags) {
			IntPtr native_info = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.MapInfo)));
			bool raw_ret = gst_buffer_map_range(Handle, idx, length, native_info, (int) flags);
			bool ret = raw_ret;
			info = Gst.MapInfo.New (native_info);
			Marshal.FreeHGlobal (native_info);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_buffer_memcmp(IntPtr raw, UIntPtr offset, byte[] mem, UIntPtr n_length);

		public int Memcmp(ulong offset, byte[] mem) {
			int raw_ret = gst_buffer_memcmp(Handle, new UIntPtr (offset), mem, new UIntPtr ((ulong) (mem == null ? 0 : mem.Length)));
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_buffer_memset(IntPtr raw, UIntPtr offset, byte val, UIntPtr size);

		public ulong Memset(ulong offset, byte val, ulong size) {
			UIntPtr raw_ret = gst_buffer_memset(Handle, new UIntPtr (offset), val, new UIntPtr (size));
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_buffer_n_memory(IntPtr raw);

		public uint NMemory() {
			uint raw_ret = gst_buffer_n_memory(Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_peek_memory(IntPtr raw, uint idx);

		public Gst.Memory PeekMemory(uint idx) {
			IntPtr raw_ret = gst_buffer_peek_memory(Handle, idx);
			Gst.Memory ret = raw_ret == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Memory), false);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_prepend_memory(IntPtr raw, IntPtr mem);

		public void PrependMemory(Gst.Memory mem) {
			mem.Owned = false;
			gst_buffer_prepend_memory(Handle, mem == null ? IntPtr.Zero : mem.Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_remove_all_memory(IntPtr raw);

		public void RemoveAllMemory() {
			gst_buffer_remove_all_memory(Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_remove_memory(IntPtr raw, uint idx);

		public void RemoveMemory(uint idx) {
			gst_buffer_remove_memory(Handle, idx);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_remove_memory_range(IntPtr raw, uint idx, int length);

		public void RemoveMemoryRange(uint idx, int length) {
			gst_buffer_remove_memory_range(Handle, idx, length);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_remove_meta(IntPtr raw, IntPtr meta);

		public bool RemoveMeta(Gst.Meta meta) {
			IntPtr native_meta = GLib.Marshaller.StructureToPtrAlloc (meta);
			bool raw_ret = gst_buffer_remove_meta(Handle, native_meta);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_meta);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_replace_all_memory(IntPtr raw, IntPtr mem);

		public void ReplaceAllMemory(Gst.Memory mem) {
			mem.Owned = false;
			gst_buffer_replace_all_memory(Handle, mem == null ? IntPtr.Zero : mem.Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_replace_memory(IntPtr raw, uint idx, IntPtr mem);

		public void ReplaceMemory(uint idx, Gst.Memory mem) {
			mem.Owned = false;
			gst_buffer_replace_memory(Handle, idx, mem == null ? IntPtr.Zero : mem.Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_replace_memory_range(IntPtr raw, uint idx, int length, IntPtr mem);

		public void ReplaceMemoryRange(uint idx, int length, Gst.Memory mem) {
			mem.Owned = false;
			gst_buffer_replace_memory_range(Handle, idx, length, mem == null ? IntPtr.Zero : mem.Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_resize(IntPtr raw, IntPtr offset, IntPtr size);

		public void Resize(long offset, long size) {
			gst_buffer_resize(Handle, new IntPtr (offset), new IntPtr (size));
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_resize_range(IntPtr raw, uint idx, int length, IntPtr offset, IntPtr size);

		public bool ResizeRange(uint idx, int length, long offset, long size) {
			bool raw_ret = gst_buffer_resize_range(Handle, idx, length, new IntPtr (offset), new IntPtr (size));
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_set_flags(IntPtr raw, int flags);

		public bool SetFlags(Gst.BufferFlags flags) {
			bool raw_ret = gst_buffer_set_flags(Handle, (int) flags);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_set_size(IntPtr raw, IntPtr size);

		public void SetSize(long size) {
			gst_buffer_set_size(Handle, new IntPtr (size));
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_unmap(IntPtr raw, IntPtr info);

		public void Unmap(Gst.MapInfo info) {
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			gst_buffer_unmap(Handle, native_info);
			Marshal.FreeHGlobal (native_info);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_unset_flags(IntPtr raw, int flags);

		public bool UnsetFlags(Gst.BufferFlags flags) {
			bool raw_ret = gst_buffer_unset_flags(Handle, (int) flags);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_buffer_get_max_memory();

		public static uint MaxMemory { 
			get {
				uint raw_ret = gst_buffer_get_max_memory();
				uint ret = raw_ret;
				return ret;
			}
		}

		public Buffer(IntPtr raw) : base(raw) {}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_new();

		public Buffer () 
		{
			Raw = gst_buffer_new();
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_new_allocate(IntPtr allocator, UIntPtr size, IntPtr parms);

		public Buffer (Gst.Allocator allocator, ulong size, Gst.AllocationParams parms) 
		{
			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			Raw = gst_buffer_new_allocate(allocator == null ? IntPtr.Zero : allocator.Handle, new UIntPtr (size), native_parms);
			Marshal.FreeHGlobal (native_parms);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_new_wrapped_bytes(IntPtr bytes);

		public Buffer (GLib.Bytes bytes) 
		{
			Raw = gst_buffer_new_wrapped_bytes(bytes == null ? IntPtr.Zero : bytes.Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_new_wrapped_full(int flags, byte[] data, UIntPtr maxsize, UIntPtr offset, UIntPtr size, IntPtr user_data, GLib.DestroyNotify notify);

		public Buffer (Gst.MemoryFlags flags, byte[] data, ulong maxsize, ulong offset, ulong size, IntPtr user_data, GLib.DestroyNotify notify) 
		{
			Raw = gst_buffer_new_wrapped_full((int) flags, data, new UIntPtr (maxsize), new UIntPtr (offset), new UIntPtr (size), user_data, notify);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gst_buffer_ref (raw);
				Owned = true;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gst_buffer_unref (raw);
				Owned = false;
			}
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gst_buffer_unref;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("pool"
							, Gst.MiniObject.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pool
							, null
							, "pts"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pts"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // pts
							, "pool"
							, "dts"
							, (long) Marshal.OffsetOf(typeof(GstBuffer_ptsAlign), "pts")
							, 0
							),
						new GLib.AbiField("dts"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // dts
							, "pts"
							, "duration"
							, (long) Marshal.OffsetOf(typeof(GstBuffer_dtsAlign), "dts")
							, 0
							),
						new GLib.AbiField("duration"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // duration
							, "dts"
							, "offset"
							, (long) Marshal.OffsetOf(typeof(GstBuffer_durationAlign), "duration")
							, 0
							),
						new GLib.AbiField("offset"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // offset
							, "duration"
							, "offset_end"
							, (long) Marshal.OffsetOf(typeof(GstBuffer_offsetAlign), "offset")
							, 0
							),
						new GLib.AbiField("offset_end"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // offset_end
							, "offset"
							, null
							, (long) Marshal.OffsetOf(typeof(GstBuffer_offset_endAlign), "offset_end")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBuffer_ptsAlign
		{
			sbyte f1;
			private ulong pts;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBuffer_dtsAlign
		{
			sbyte f1;
			private ulong dts;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBuffer_durationAlign
		{
			sbyte f1;
			private ulong duration;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBuffer_offsetAlign
		{
			sbyte f1;
			private ulong offset;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBuffer_offset_endAlign
		{
			sbyte f1;
			private ulong offset_end;
		}


		// End of the ABI representation.

#endregion
	}
}
