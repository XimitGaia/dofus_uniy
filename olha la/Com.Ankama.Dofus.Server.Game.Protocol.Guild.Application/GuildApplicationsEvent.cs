using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x200050D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationsEvent : IMessage<GuildApplicationsEvent>, IMessage, IEquatable<GuildApplicationsEvent>, IDeepCloneable<GuildApplicationsEvent>, IBufferMessage
{
	[Token(Token = "0x400112C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationsEvent> _parser;

	[Token(Token = "0x400112D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400112E")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x400112F")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4001130")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x20")]
	private long count_;

	[Token(Token = "0x4001132")]
	public const int TotalFieldNumber = 3;

	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x28")]
	private long total_;

	[Token(Token = "0x4001134")]
	public const int AppliesFieldNumber = 4;

	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<SocialApplicationInformation> _repeated_applies_codec;

	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<SocialApplicationInformation> applies_;

	[Token(Token = "0x17000B53")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildApplicationsEvent> Parser
	{
		[Token(Token = "0x600356B")]
		[Address(RVA = "0xA01430", Offset = "0xA00830", VA = "0x180A01430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B54")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600356C")]
		[Address(RVA = "0xA01380", Offset = "0xA00780", VA = "0x180A01380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B55")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600356D")]
		[Address(RVA = "0xA01710", Offset = "0xA00B10", VA = "0x180A01710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B56")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Offset
	{
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003572")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000B57")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Count
	{
		[Token(Token = "0x6003573")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003574")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B58")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Total
	{
		[Token(Token = "0x6003575")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000B59")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SocialApplicationInformation> Applies
	{
		[Token(Token = "0x6003577")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600356E")]
	[Address(RVA = "0xA01250", Offset = "0xA00650", VA = "0x180A01250")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationsEvent()
	{
	}

	[Token(Token = "0x600356F")]
	[Address(RVA = "0xA012D0", Offset = "0xA006D0", VA = "0x180A012D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationsEvent(GuildApplicationsEvent other)
	{
	}

	[Token(Token = "0x6003570")]
	[Address(RVA = "0xA00D30", Offset = "0xA00130", VA = "0x180A00D30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003578")]
	[Address(RVA = "0xA00EB0", Offset = "0xA002B0", VA = "0x180A00EB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003579")]
	[Address(RVA = "0xA00E00", Offset = "0xA00200", VA = "0x180A00E00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600357A")]
	[Address(RVA = "0x9DD5E0", Offset = "0x9DC9E0", VA = "0x1809DD5E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600357B")]
	[Address(RVA = "0xA01050", Offset = "0xA00450", VA = "0x180A01050", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600357C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600357D")]
	[Address(RVA = "0xA015F0", Offset = "0xA009F0", VA = "0x180A015F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600357E")]
	[Address(RVA = "0xA00BF0", Offset = "0x9FFFF0", VA = "0x180A00BF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600357F")]
	[Address(RVA = "0xA00FA0", Offset = "0xA003A0", VA = "0x180A00FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationsEvent other)
	{
	}

	[Token(Token = "0x6003580")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003581")]
	[Address(RVA = "0xA01480", Offset = "0xA00880", VA = "0x180A01480", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
