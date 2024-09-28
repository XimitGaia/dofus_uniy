using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x200090B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachSavedEvent : IMessage<BreachSavedEvent>, IMessage, IEquatable<BreachSavedEvent>, IDeepCloneable<BreachSavedEvent>, IBufferMessage
{
	[Token(Token = "0x4001EF0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachSavedEvent> _parser;

	[Token(Token = "0x4001EF1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EF2")]
	public const int SavedFieldNumber = 1;

	[Token(Token = "0x4001EF3")]
	[FieldOffset(Offset = "0x18")]
	private bool saved_;

	[Token(Token = "0x1700143D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachSavedEvent> Parser
	{
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0xB56DD0", Offset = "0xB561D0", VA = "0x180B56DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0xB56D20", Offset = "0xB56120", VA = "0x180B56D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0xB56E20", Offset = "0xB56220", VA = "0x180B56E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001440")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Saved
	{
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005FA8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachSavedEvent()
	{
	}

	[Token(Token = "0x6005FA9")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachSavedEvent(BreachSavedEvent other)
	{
	}

	[Token(Token = "0x6005FAA")]
	[Address(RVA = "0xB56A10", Offset = "0xB55E10", VA = "0x180B56A10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachSavedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005FAD")]
	[Address(RVA = "0xB56A90", Offset = "0xB55E90", VA = "0x180B56A90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FAE")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachSavedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FAF")]
	[Address(RVA = "0xB56B20", Offset = "0xB55F20", VA = "0x180B56B20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005FB0")]
	[Address(RVA = "0xB56BC0", Offset = "0xB55FC0", VA = "0x180B56BC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005FB1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005FB2")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005FB3")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005FB4")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachSavedEvent other)
	{
	}

	[Token(Token = "0x6005FB5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005FB6")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
