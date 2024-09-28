using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CC4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceSummaryEvent : IMessage<AllianceSummaryEvent>, IMessage, IEquatable<AllianceSummaryEvent>, IDeepCloneable<AllianceSummaryEvent>, IBufferMessage
{
	[Token(Token = "0x4002F18")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceSummaryEvent> _parser;

	[Token(Token = "0x4002F19")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F1A")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x4002F1B")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4002F1C")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4002F1D")]
	[FieldOffset(Offset = "0x20")]
	private long count_;

	[Token(Token = "0x4002F1E")]
	public const int TotalFieldNumber = 3;

	[Token(Token = "0x4002F1F")]
	[FieldOffset(Offset = "0x28")]
	private long total_;

	[Token(Token = "0x4002F20")]
	public const int AlliancesFieldNumber = 4;

	[Token(Token = "0x4002F21")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<AllianceInformation> _repeated_alliances_codec;

	[Token(Token = "0x4002F22")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<AllianceInformation> alliances_;

	[Token(Token = "0x17001D6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceSummaryEvent> Parser
	{
		[Token(Token = "0x6008681")]
		[Address(RVA = "0xC9C810", Offset = "0xC9BC10", VA = "0x180C9C810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008682")]
		[Address(RVA = "0xC9C760", Offset = "0xC9BB60", VA = "0x180C9C760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D71")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008683")]
		[Address(RVA = "0xC9CAF0", Offset = "0xC9BEF0", VA = "0x180C9CAF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D72")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Offset
	{
		[Token(Token = "0x6008687")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008688")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001D73")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Count
	{
		[Token(Token = "0x6008689")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600868A")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D74")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Total
	{
		[Token(Token = "0x600868B")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600868C")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17001D75")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AllianceInformation> Alliances
	{
		[Token(Token = "0x600868D")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008684")]
	[Address(RVA = "0xC9C6E0", Offset = "0xC9BAE0", VA = "0x180C9C6E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceSummaryEvent()
	{
	}

	[Token(Token = "0x6008685")]
	[Address(RVA = "0xC9C630", Offset = "0xC9BA30", VA = "0x180C9C630")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceSummaryEvent(AllianceSummaryEvent other)
	{
	}

	[Token(Token = "0x6008686")]
	[Address(RVA = "0xC9C110", Offset = "0xC9B510", VA = "0x180C9C110", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceSummaryEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600868E")]
	[Address(RVA = "0xC9C290", Offset = "0xC9B690", VA = "0x180C9C290", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600868F")]
	[Address(RVA = "0xC9C1E0", Offset = "0xC9B5E0", VA = "0x180C9C1E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceSummaryEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008690")]
	[Address(RVA = "0x9DD5E0", Offset = "0x9DC9E0", VA = "0x1809DD5E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008691")]
	[Address(RVA = "0xC9C430", Offset = "0xC9B830", VA = "0x180C9C430", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008692")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008693")]
	[Address(RVA = "0xC9C9D0", Offset = "0xC9BDD0", VA = "0x180C9C9D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008694")]
	[Address(RVA = "0xC9BFD0", Offset = "0xC9B3D0", VA = "0x180C9BFD0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008695")]
	[Address(RVA = "0xC9C380", Offset = "0xC9B780", VA = "0x180C9C380", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceSummaryEvent other)
	{
	}

	[Token(Token = "0x6008696")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008697")]
	[Address(RVA = "0xC9C860", Offset = "0xC9BC60", VA = "0x180C9C860", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
