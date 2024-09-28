using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000447")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagInvitationClosedEvent : IMessage<HavenBagInvitationClosedEvent>, IMessage, IEquatable<HavenBagInvitationClosedEvent>, IDeepCloneable<HavenBagInvitationClosedEvent>, IBufferMessage
{
	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagInvitationClosedEvent> _parser;

	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EC5")]
	public const int HostInformationFieldNumber = 1;

	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character hostInformation_;

	[Token(Token = "0x1700099F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagInvitationClosedEvent> Parser
	{
		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x9BD3F0", Offset = "0x9BC7F0", VA = "0x1809BD3F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x9BD340", Offset = "0x9BC740", VA = "0x1809BD340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x9BD540", Offset = "0x9BC940", VA = "0x1809BD540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character HostInformation
	{
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationClosedEvent()
	{
	}

	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0x9BD2D0", Offset = "0x9BC6D0", VA = "0x1809BD2D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationClosedEvent(HavenBagInvitationClosedEvent other)
	{
	}

	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0x9BCF50", Offset = "0x9BC350", VA = "0x1809BCF50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationClosedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002D11")]
	[Address(RVA = "0x9BCFF0", Offset = "0x9BC3F0", VA = "0x1809BCFF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D12")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagInvitationClosedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D13")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002D14")]
	[Address(RVA = "0x9BD170", Offset = "0x9BC570", VA = "0x1809BD170", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002D15")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002D16")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x9BCEC0", Offset = "0x9BC2C0", VA = "0x1809BCEC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002D18")]
	[Address(RVA = "0x9BD0A0", Offset = "0x9BC4A0", VA = "0x1809BD0A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagInvitationClosedEvent other)
	{
	}

	[Token(Token = "0x6002D19")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002D1A")]
	[Address(RVA = "0x9BD440", Offset = "0x9BC840", VA = "0x1809BD440", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
