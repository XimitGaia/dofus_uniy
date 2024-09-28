using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x2000606")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightFighterShowEvent : IMessage<FightFighterShowEvent>, IMessage, IEquatable<FightFighterShowEvent>, IDeepCloneable<FightFighterShowEvent>, IBufferMessage
{
	[Token(Token = "0x400151B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightFighterShowEvent> _parser;

	[Token(Token = "0x400151C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400151D")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x18")]
	private ActorPositionInformation information_;

	[Token(Token = "0x400151F")]
	public const int StaticPoseFieldNumber = 2;

	[Token(Token = "0x4001520")]
	[FieldOffset(Offset = "0x20")]
	private bool staticPose_;

	[Token(Token = "0x17000DD5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightFighterShowEvent> Parser
	{
		[Token(Token = "0x6004069")]
		[Address(RVA = "0xA3E7D0", Offset = "0xA3DBD0", VA = "0x180A3E7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600406A")]
		[Address(RVA = "0xA3E720", Offset = "0xA3DB20", VA = "0x180A3E720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600406B")]
		[Address(RVA = "0xA3E950", Offset = "0xA3DD50", VA = "0x180A3E950", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActorPositionInformation Information
	{
		[Token(Token = "0x600406F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000DD9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool StaticPose
	{
		[Token(Token = "0x6004071")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004072")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x600406C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFighterShowEvent()
	{
	}

	[Token(Token = "0x600406D")]
	[Address(RVA = "0xA3E6A0", Offset = "0xA3DAA0", VA = "0x180A3E6A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFighterShowEvent(FightFighterShowEvent other)
	{
	}

	[Token(Token = "0x600406E")]
	[Address(RVA = "0xA3E240", Offset = "0xA3D640", VA = "0x180A3E240", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFighterShowEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004073")]
	[Address(RVA = "0xA3E2F0", Offset = "0xA3D6F0", VA = "0x180A3E2F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004074")]
	[Address(RVA = "0x9BD760", Offset = "0x9BCB60", VA = "0x1809BD760", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightFighterShowEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004075")]
	[Address(RVA = "0xA3E3A0", Offset = "0xA3D7A0", VA = "0x180A3E3A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004076")]
	[Address(RVA = "0xA3E540", Offset = "0xA3D940", VA = "0x180A3E540", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004077")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004078")]
	[Address(RVA = "0x9BDE30", Offset = "0x9BD230", VA = "0x1809BDE30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004079")]
	[Address(RVA = "0xA3E1B0", Offset = "0xA3D5B0", VA = "0x180A3E1B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600407A")]
	[Address(RVA = "0xA3E460", Offset = "0xA3D860", VA = "0x180A3E460", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightFighterShowEvent other)
	{
	}

	[Token(Token = "0x600407B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600407C")]
	[Address(RVA = "0xA3E820", Offset = "0xA3DC20", VA = "0x180A3E820", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
