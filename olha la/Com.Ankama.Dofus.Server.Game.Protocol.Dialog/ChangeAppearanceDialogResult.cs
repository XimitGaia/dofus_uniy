using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog;

[Token(Token = "0x2000768")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChangeAppearanceDialogResult : IMessage<ChangeAppearanceDialogResult>, IMessage, IEquatable<ChangeAppearanceDialogResult>, IDeepCloneable<ChangeAppearanceDialogResult>, IBufferMessage
{
	[Token(Token = "0x40019EE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChangeAppearanceDialogResult> _parser;

	[Token(Token = "0x40019EF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019F0")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x40019F1")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x170010EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChangeAppearanceDialogResult> Parser
	{
		[Token(Token = "0x6004F2E")]
		[Address(RVA = "0xAC9B30", Offset = "0xAC8F30", VA = "0x180AC9B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0xAC9A80", Offset = "0xAC8E80", VA = "0x180AC9A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010F1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004F30")]
		[Address(RVA = "0xAC9B80", Offset = "0xAC8F80", VA = "0x180AC9B80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6004F31")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeAppearanceDialogResult()
	{
	}

	[Token(Token = "0x6004F32")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeAppearanceDialogResult(ChangeAppearanceDialogResult other)
	{
	}

	[Token(Token = "0x6004F33")]
	[Address(RVA = "0xAC9770", Offset = "0xAC8B70", VA = "0x180AC9770", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeAppearanceDialogResult Clone()
	{
		return null;
	}

	[Token(Token = "0x6004F36")]
	[Address(RVA = "0xAC97F0", Offset = "0xAC8BF0", VA = "0x180AC97F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F37")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChangeAppearanceDialogResult other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F38")]
	[Address(RVA = "0xAC9880", Offset = "0xAC8C80", VA = "0x180AC9880", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004F39")]
	[Address(RVA = "0xAC9920", Offset = "0xAC8D20", VA = "0x180AC9920", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004F3A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004F3B")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004F3C")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004F3D")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChangeAppearanceDialogResult other)
	{
	}

	[Token(Token = "0x6004F3E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004F3F")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
