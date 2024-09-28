using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C72")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationModifiedEvent : IMessage<AllianceApplicationModifiedEvent>, IMessage, IEquatable<AllianceApplicationModifiedEvent>, IDeepCloneable<AllianceApplicationModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x4002E01")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationModifiedEvent> _parser;

	[Token(Token = "0x4002E02")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E03")]
	public const int ApplyFieldNumber = 1;

	[Token(Token = "0x4002E04")]
	[FieldOffset(Offset = "0x18")]
	private SocialApplicationInformation apply_;

	[Token(Token = "0x4002E05")]
	public const int StateFieldNumber = 2;

	[Token(Token = "0x4002E06")]
	[FieldOffset(Offset = "0x20")]
	private SocialApplicationState state_;

	[Token(Token = "0x4002E07")]
	public const int PlayerIdFieldNumber = 3;

	[Token(Token = "0x4002E08")]
	[FieldOffset(Offset = "0x28")]
	private long playerId_;

	[Token(Token = "0x17001CB3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationModifiedEvent> Parser
	{
		[Token(Token = "0x60082FE")]
		[Address(RVA = "0xC71C70", Offset = "0xC71070", VA = "0x180C71C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CB4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60082FF")]
		[Address(RVA = "0xC71BC0", Offset = "0xC70FC0", VA = "0x180C71BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CB5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008300")]
		[Address(RVA = "0xC71E00", Offset = "0xC71200", VA = "0x180C71E00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CB6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialApplicationInformation Apply
	{
		[Token(Token = "0x6008304")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008305")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001CB7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialApplicationState State
	{
		[Token(Token = "0x6008306")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SocialApplicationState);
		}
		[Token(Token = "0x6008307")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001CB8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x6008308")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008309")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6008301")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationModifiedEvent()
	{
	}

	[Token(Token = "0x6008302")]
	[Address(RVA = "0x9FF8E0", Offset = "0x9FECE0", VA = "0x1809FF8E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationModifiedEvent(AllianceApplicationModifiedEvent other)
	{
	}

	[Token(Token = "0x6008303")]
	[Address(RVA = "0xC71810", Offset = "0xC70C10", VA = "0x180C71810", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600830A")]
	[Address(RVA = "0xC718C0", Offset = "0xC70CC0", VA = "0x180C718C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600830B")]
	[Address(RVA = "0x9FF570", Offset = "0x9FE970", VA = "0x1809FF570", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceApplicationModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600830C")]
	[Address(RVA = "0x9FF5F0", Offset = "0x9FE9F0", VA = "0x1809FF5F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600830D")]
	[Address(RVA = "0xC71A60", Offset = "0xC70E60", VA = "0x180C71A60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600830E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600830F")]
	[Address(RVA = "0x9FFBA0", Offset = "0x9FEFA0", VA = "0x1809FFBA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008310")]
	[Address(RVA = "0xC71720", Offset = "0xC70B20", VA = "0x180C71720", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008311")]
	[Address(RVA = "0xC71980", Offset = "0xC70D80", VA = "0x180C71980", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationModifiedEvent other)
	{
	}

	[Token(Token = "0x6008312")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008313")]
	[Address(RVA = "0xC71CC0", Offset = "0xC710C0", VA = "0x180C71CC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
