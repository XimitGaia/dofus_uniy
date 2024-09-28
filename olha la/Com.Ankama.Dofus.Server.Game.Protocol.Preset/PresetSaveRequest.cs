using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000201")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSaveRequest : IMessage<PresetSaveRequest>, IMessage, IEquatable<PresetSaveRequest>, IDeepCloneable<PresetSaveRequest>, IBufferMessage
{
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSaveRequest> _parser;

	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006D3")]
	public const int TypeFieldNumber = 1;

	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x18")]
	private PresetType type_;

	[Token(Token = "0x40006D5")]
	public const int UuidFieldNumber = 2;

	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x20")]
	private string uuid_;

	[Token(Token = "0x1700045C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetSaveRequest> Parser
	{
		[Token(Token = "0x600145D")]
		[Address(RVA = "0xCE6780", Offset = "0xCE5B80", VA = "0x180CE6780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600145E")]
		[Address(RVA = "0xCE66D0", Offset = "0xCE5AD0", VA = "0x180CE66D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600145F")]
		[Address(RVA = "0xCE68A0", Offset = "0xCE5CA0", VA = "0x180CE68A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetType Type
	{
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(PresetType);
		}
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000460")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001466")]
		[Address(RVA = "0xCE6980", Offset = "0xCE5D80", VA = "0x180CE6980")]
		set
		{
		}
	}

	[Token(Token = "0x6001460")]
	[Address(RVA = "0xCE6680", Offset = "0xCE5A80", VA = "0x180CE6680")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSaveRequest()
	{
	}

	[Token(Token = "0x6001461")]
	[Address(RVA = "0xCE65D0", Offset = "0xCE59D0", VA = "0x180CE65D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSaveRequest(PresetSaveRequest other)
	{
	}

	[Token(Token = "0x6001462")]
	[Address(RVA = "0xCE6280", Offset = "0xCE5680", VA = "0x180CE6280", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSaveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001467")]
	[Address(RVA = "0xCE6350", Offset = "0xCE5750", VA = "0x180CE6350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001468")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetSaveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001469")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600146A")]
	[Address(RVA = "0xCE6470", Offset = "0xCE5870", VA = "0x180CE6470", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600146B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600146C")]
	[Address(RVA = "0xAD91E0", Offset = "0xAD85E0", VA = "0x180AD91E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600146D")]
	[Address(RVA = "0xCE61C0", Offset = "0xCE55C0", VA = "0x180CE61C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600146E")]
	[Address(RVA = "0xCE6400", Offset = "0xCE5800", VA = "0x180CE6400", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetSaveRequest other)
	{
	}

	[Token(Token = "0x600146F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001470")]
	[Address(RVA = "0xCE67D0", Offset = "0xCE5BD0", VA = "0x180CE67D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
