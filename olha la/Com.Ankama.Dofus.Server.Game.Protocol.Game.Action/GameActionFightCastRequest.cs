using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x200055D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionFightCastRequest : IMessage<GameActionFightCastRequest>, IMessage, IEquatable<GameActionFightCastRequest>, IDeepCloneable<GameActionFightCastRequest>, IBufferMessage
{
	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionFightCastRequest> _parser;

	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001269")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x400126B")]
	public const int CellFieldNumber = 2;

	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0x1C")]
	private int cell_;

	[Token(Token = "0x17000C14")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GameActionFightCastRequest> Parser
	{
		[Token(Token = "0x60038D3")]
		[Address(RVA = "0xA13500", Offset = "0xA12900", VA = "0x180A13500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C15")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60038D4")]
		[Address(RVA = "0xA13450", Offset = "0xA12850", VA = "0x180A13450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C16")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0xA13550", Offset = "0xA12950", VA = "0x180A13550", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C17")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellId
	{
		[Token(Token = "0x60038D9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60038DA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000C18")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Cell
	{
		[Token(Token = "0x60038DB")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60038DC")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60038D6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GameActionFightCastRequest()
	{
	}

	[Token(Token = "0x60038D7")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionFightCastRequest(GameActionFightCastRequest other)
	{
	}

	[Token(Token = "0x60038D8")]
	[Address(RVA = "0xA131D0", Offset = "0xA125D0", VA = "0x180A131D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionFightCastRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60038DD")]
	[Address(RVA = "0xA13260", Offset = "0xA12660", VA = "0x180A13260", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038DE")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionFightCastRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038DF")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60038E0")]
	[Address(RVA = "0xA132F0", Offset = "0xA126F0", VA = "0x180A132F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60038E1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60038E2")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60038E3")]
	[Address(RVA = "0xA13110", Offset = "0xA12510", VA = "0x180A13110", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60038E4")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionFightCastRequest other)
	{
	}

	[Token(Token = "0x60038E5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60038E6")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
