using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Recruitment;

[Token(Token = "0x200045B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRecruitmentEvent : IMessage<GuildRecruitmentEvent>, IMessage, IEquatable<GuildRecruitmentEvent>, IDeepCloneable<GuildRecruitmentEvent>, IBufferMessage
{
	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRecruitmentEvent> _parser;

	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EF8")]
	public const int RecruitmentFieldNumber = 1;

	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x18")]
	private GuildRecruitmentInformation recruitment_;

	[Token(Token = "0x170009C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRecruitmentEvent> Parser
	{
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x9B4610", Offset = "0x9B3A10", VA = "0x1809B4610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x9B4560", Offset = "0x9B3960", VA = "0x1809B4560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x9B4760", Offset = "0x9B3B60", VA = "0x1809B4760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentInformation Recruitment
	{
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentEvent()
	{
	}

	[Token(Token = "0x6002DDB")]
	[Address(RVA = "0x9B44F0", Offset = "0x9B38F0", VA = "0x1809B44F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentEvent(GuildRecruitmentEvent other)
	{
	}

	[Token(Token = "0x6002DDC")]
	[Address(RVA = "0x9B4170", Offset = "0x9B3570", VA = "0x1809B4170", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRecruitmentEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002DDF")]
	[Address(RVA = "0x9B4210", Offset = "0x9B3610", VA = "0x1809B4210", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DE0")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRecruitmentEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DE1")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002DE2")]
	[Address(RVA = "0x9B4390", Offset = "0x9B3790", VA = "0x1809B4390", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002DE4")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002DE5")]
	[Address(RVA = "0x9B40E0", Offset = "0x9B34E0", VA = "0x1809B40E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x9B42C0", Offset = "0x9B36C0", VA = "0x1809B42C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRecruitmentEvent other)
	{
	}

	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x9B4660", Offset = "0x9B3A60", VA = "0x1809B4660", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
