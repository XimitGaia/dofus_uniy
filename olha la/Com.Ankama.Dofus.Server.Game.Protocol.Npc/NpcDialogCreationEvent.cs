using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002D9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcDialogCreationEvent : IMessage<NpcDialogCreationEvent>, IMessage, IEquatable<NpcDialogCreationEvent>, IDeepCloneable<NpcDialogCreationEvent>, IBufferMessage
{
	[Token(Token = "0x20002DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20002DB")]
		public enum PortalType
		{
			[Token(Token = "0x4000A08")]
			[OriginalName("UNSUPPORTED")]
			Unsupported,
			[Token(Token = "0x4000A09")]
			[OriginalName("ENUTROSOR")]
			Enutrosor,
			[Token(Token = "0x4000A0A")]
			[OriginalName("SRAMBAD")]
			Srambad,
			[Token(Token = "0x4000A0B")]
			[OriginalName("XELORIUM")]
			Xelorium,
			[Token(Token = "0x4000A0C")]
			[OriginalName("ECAFLIPUS")]
			Ecaflipus
		}
	}

	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NpcDialogCreationEvent> _parser;

	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4000A00")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x4000A02")]
	public const int NpcIdFieldNumber = 2;

	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x28")]
	private int npcId_;

	[Token(Token = "0x4000A04")]
	public const int PortalTypeFieldNumber = 3;

	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Types.PortalType PortalTypeDefaultValue;

	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x2C")]
	private Types.PortalType portalType_;

	[Token(Token = "0x17000661")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<NpcDialogCreationEvent> Parser
	{
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0xD26DF0", Offset = "0xD261F0", VA = "0x180D26DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000662")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0xD26D40", Offset = "0xD26140", VA = "0x180D26D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000663")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0xD27070", Offset = "0xD26470", VA = "0x180D27070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000664")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000665")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NpcId
	{
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000666")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PortalType PortalType
	{
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0xD26E40", Offset = "0xD26240", VA = "0x180D26E40")]
		get
		{
			return default(Types.PortalType);
		}
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0xD27150", Offset = "0xD26550", VA = "0x180D27150")]
		set
		{
		}
	}

	[Token(Token = "0x17000667")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPortalType
	{
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001D99")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcDialogCreationEvent()
	{
	}

	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0xB6ABC0", Offset = "0xB69FC0", VA = "0x180B6ABC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcDialogCreationEvent(NpcDialogCreationEvent other)
	{
	}

	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0xD26880", Offset = "0xD25C80", VA = "0x180D26880", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcDialogCreationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearPortalType()
	{
	}

	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0xD26910", Offset = "0xD25D10", VA = "0x180D26910", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0xD269D0", Offset = "0xD25DD0", VA = "0x180D269D0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NpcDialogCreationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0xD26A60", Offset = "0xD25E60", VA = "0x180D26A60", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0xD26BD0", Offset = "0xD25FD0", VA = "0x180D26BD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0xD26F80", Offset = "0xD26380", VA = "0x180D26F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0xD26750", Offset = "0xD25B50", VA = "0x180D26750", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0xD26B60", Offset = "0xD25F60", VA = "0x180D26B60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcDialogCreationEvent other)
	{
	}

	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0xD26EB0", Offset = "0xD262B0", VA = "0x180D26EB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
