using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog;

[Token(Token = "0x2000766")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChangeAppearanceDialogLeave : IMessage<ChangeAppearanceDialogLeave>, IMessage, IEquatable<ChangeAppearanceDialogLeave>, IDeepCloneable<ChangeAppearanceDialogLeave>, IBufferMessage
{
	[Token(Token = "0x40019EB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChangeAppearanceDialogLeave> _parser;

	[Token(Token = "0x40019EC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170010EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChangeAppearanceDialogLeave> Parser
	{
		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0xAC9640", Offset = "0xAC8A40", VA = "0x180AC9640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004F1B")]
		[Address(RVA = "0xAC9590", Offset = "0xAC8990", VA = "0x180AC9590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0xAC9690", Offset = "0xAC8A90", VA = "0x180AC9690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F1D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeAppearanceDialogLeave()
	{
	}

	[Token(Token = "0x6004F1E")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeAppearanceDialogLeave(ChangeAppearanceDialogLeave other)
	{
	}

	[Token(Token = "0x6004F1F")]
	[Address(RVA = "0xAC9330", Offset = "0xAC8730", VA = "0x180AC9330", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeAppearanceDialogLeave Clone()
	{
		return null;
	}

	[Token(Token = "0x6004F20")]
	[Address(RVA = "0xAC93B0", Offset = "0xAC87B0", VA = "0x180AC93B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F21")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ChangeAppearanceDialogLeave other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F22")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004F23")]
	[Address(RVA = "0xAC9430", Offset = "0xAC8830", VA = "0x180AC9430", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004F24")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004F25")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004F26")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004F27")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChangeAppearanceDialogLeave other)
	{
	}

	[Token(Token = "0x6004F28")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004F29")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
