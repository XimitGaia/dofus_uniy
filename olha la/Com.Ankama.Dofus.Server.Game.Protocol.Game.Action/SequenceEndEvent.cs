using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x20005C7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SequenceEndEvent : IMessage<SequenceEndEvent>, IMessage, IEquatable<SequenceEndEvent>, IDeepCloneable<SequenceEndEvent>, IBufferMessage
{
	[Token(Token = "0x4001425")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SequenceEndEvent> _parser;

	[Token(Token = "0x4001426")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001427")]
	public const int ActionIdFieldNumber = 1;

	[Token(Token = "0x4001428")]
	[FieldOffset(Offset = "0x18")]
	private int actionId_;

	[Token(Token = "0x4001429")]
	public const int AuthorIdFieldNumber = 2;

	[Token(Token = "0x400142A")]
	[FieldOffset(Offset = "0x20")]
	private long authorId_;

	[Token(Token = "0x400142B")]
	public const int SequenceTypeFieldNumber = 3;

	[Token(Token = "0x400142C")]
	[FieldOffset(Offset = "0x28")]
	private SequenceType sequenceType_;

	[Token(Token = "0x17000D35")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SequenceEndEvent> Parser
	{
		[Token(Token = "0x6003DAD")]
		[Address(RVA = "0xA302C0", Offset = "0xA2F6C0", VA = "0x180A302C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D36")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003DAE")]
		[Address(RVA = "0xA30210", Offset = "0xA2F610", VA = "0x180A30210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D37")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003DAF")]
		[Address(RVA = "0xA303B0", Offset = "0xA2F7B0", VA = "0x180A303B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D38")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ActionId
	{
		[Token(Token = "0x6003DB3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000D39")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AuthorId
	{
		[Token(Token = "0x6003DB5")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003DB6")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceType SequenceType
	{
		[Token(Token = "0x6003DB7")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(SequenceType);
		}
		[Token(Token = "0x6003DB8")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6003DB0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceEndEvent()
	{
	}

	[Token(Token = "0x6003DB1")]
	[Address(RVA = "0x963AD0", Offset = "0x962ED0", VA = "0x180963AD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceEndEvent(SequenceEndEvent other)
	{
	}

	[Token(Token = "0x6003DB2")]
	[Address(RVA = "0xA2FED0", Offset = "0xA2F2D0", VA = "0x180A2FED0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceEndEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003DB9")]
	[Address(RVA = "0xA2FF60", Offset = "0xA2F360", VA = "0x180A2FF60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DBA")]
	[Address(RVA = "0x963810", Offset = "0x962C10", VA = "0x180963810", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SequenceEndEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DBB")]
	[Address(RVA = "0xA30000", Offset = "0xA2F400", VA = "0x180A30000", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003DBC")]
	[Address(RVA = "0xA300B0", Offset = "0xA2F4B0", VA = "0x180A300B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003DBD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003DBE")]
	[Address(RVA = "0xA30310", Offset = "0xA2F710", VA = "0x180A30310", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003DBF")]
	[Address(RVA = "0xA2FDF0", Offset = "0xA2F1F0", VA = "0x180A2FDF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003DC0")]
	[Address(RVA = "0x963900", Offset = "0x962D00", VA = "0x180963900", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SequenceEndEvent other)
	{
	}

	[Token(Token = "0x6003DC1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003DC2")]
	[Address(RVA = "0x963C30", Offset = "0x963030", VA = "0x180963C30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
