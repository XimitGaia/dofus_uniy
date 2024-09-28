using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000C9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddTagStorageRequest : IMessage<AddTagStorageRequest>, IMessage, IEquatable<AddTagStorageRequest>, IDeepCloneable<AddTagStorageRequest>, IBufferMessage
{
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AddTagStorageRequest> _parser;

	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002B9")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x40002BB")]
	public const int PictoFieldNumber = 2;

	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x20")]
	private int picto_;

	[Token(Token = "0x170001A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddTagStorageRequest> Parser
	{
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xA571D0", Offset = "0xA565D0", VA = "0x180A571D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xA57120", Offset = "0xA56520", VA = "0x180A57120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xA572F0", Offset = "0xA566F0", VA = "0x180A572F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xA573D0", Offset = "0xA567D0", VA = "0x180A573D0")]
		set
		{
		}
	}

	[Token(Token = "0x170001A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Picto
	{
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0xA570D0", Offset = "0xA564D0", VA = "0x180A570D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagStorageRequest()
	{
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0xA57020", Offset = "0xA56420", VA = "0x180A57020")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagStorageRequest(AddTagStorageRequest other)
	{
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0xA56CD0", Offset = "0xA560D0", VA = "0x180A56CD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagStorageRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0xA56DA0", Offset = "0xA561A0", VA = "0x180A56DA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AddTagStorageRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0xA56EC0", Offset = "0xA562C0", VA = "0x180A56EC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0xA56C10", Offset = "0xA56010", VA = "0x180A56C10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0xA56E50", Offset = "0xA56250", VA = "0x180A56E50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AddTagStorageRequest other)
	{
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0xA57220", Offset = "0xA56620", VA = "0x180A57220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
