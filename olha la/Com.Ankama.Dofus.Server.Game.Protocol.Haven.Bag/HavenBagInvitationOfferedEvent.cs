using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200044B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagInvitationOfferedEvent : IMessage<HavenBagInvitationOfferedEvent>, IMessage, IEquatable<HavenBagInvitationOfferedEvent>, IDeepCloneable<HavenBagInvitationOfferedEvent>, IBufferMessage
{
	[Token(Token = "0x4000ECF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagInvitationOfferedEvent> _parser;

	[Token(Token = "0x4000ED0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000ED1")]
	public const int HostInformationFieldNumber = 1;

	[Token(Token = "0x4000ED2")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character hostInformation_;

	[Token(Token = "0x4000ED3")]
	public const int TimeBeforeCancelFieldNumber = 2;

	[Token(Token = "0x4000ED4")]
	[FieldOffset(Offset = "0x20")]
	private long timeBeforeCancel_;

	[Token(Token = "0x170009A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagInvitationOfferedEvent> Parser
	{
		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x9BE530", Offset = "0x9BD930", VA = "0x1809BE530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x9BE480", Offset = "0x9BD880", VA = "0x1809BE480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x9BE6A0", Offset = "0x9BDAA0", VA = "0x1809BE6A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009AB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character HostInformation
	{
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170009AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TimeBeforeCancel
	{
		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationOfferedEvent()
	{
	}

	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x9BE400", Offset = "0x9BD800", VA = "0x1809BE400")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagInvitationOfferedEvent(HavenBagInvitationOfferedEvent other)
	{
	}

	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x9BE050", Offset = "0x9BD450", VA = "0x1809BE050", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationOfferedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x9BE100", Offset = "0x9BD500", VA = "0x1809BE100", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x9719A0", Offset = "0x970DA0", VA = "0x1809719A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagInvitationOfferedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x971AD0", Offset = "0x970ED0", VA = "0x180971AD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x9BE2A0", Offset = "0x9BD6A0", VA = "0x1809BE2A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002D46")]
	[Address(RVA = "0x972120", Offset = "0x971520", VA = "0x180972120", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x9BDF90", Offset = "0x9BD390", VA = "0x1809BDF90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x9BE1C0", Offset = "0x9BD5C0", VA = "0x1809BE1C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagInvitationOfferedEvent other)
	{
	}

	[Token(Token = "0x6002D49")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x9BE580", Offset = "0x9BD980", VA = "0x1809BE580", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
