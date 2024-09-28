using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Ui;

[Token(Token = "0x2000018")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientUIOpenedEvent : IMessage<ClientUIOpenedEvent>, IMessage, IEquatable<ClientUIOpenedEvent>, IDeepCloneable<ClientUIOpenedEvent>, IBufferMessage
{
	[Token(Token = "0x2000019")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200001A")]
		public enum UIType
		{
			[Token(Token = "0x4000053")]
			[OriginalName("UNDEFINED")]
			Undefined,
			[Token(Token = "0x4000054")]
			[OriginalName("TELEPORT_GUILD_HOUSE")]
			TeleportGuildHouse,
			[Token(Token = "0x4000055")]
			[OriginalName("TELEPORT_GUILD_PADDOCK")]
			TeleportGuildPaddock,
			[Token(Token = "0x4000056")]
			[OriginalName("OBJECT_MIMICRY")]
			ObjectMimicry,
			[Token(Token = "0x4000057")]
			[OriginalName("LEGENDARY_TREASURE_QUEST")]
			LegendaryTreasureQuest,
			[Token(Token = "0x4000058")]
			[OriginalName("TELEPORT_HOUSE")]
			TeleportHouse
		}
	}

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ClientUIOpenedEvent> _parser;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x400004D")]
	public const int TypeFieldNumber = 1;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x1C")]
	private Types.UIType type_;

	[Token(Token = "0x400004F")]
	public const int ObjectUidFieldNumber = 2;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int ObjectUidDefaultValue;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x20")]
	private int objectUid_;

	[Token(Token = "0x17000024")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ClientUIOpenedEvent> Parser
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9396B0", Offset = "0x938AB0", VA = "0x1809396B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000025")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x939590", Offset = "0x938990", VA = "0x180939590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x939880", Offset = "0x938C80", VA = "0x180939880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000027")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.UIType Type
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.UIType);
		}
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x939640", Offset = "0x938A40", VA = "0x180939640")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x939960", Offset = "0x938D60", VA = "0x180939960")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasObjectUid
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientUIOpenedEvent()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ClientUIOpenedEvent(ClientUIOpenedEvent other)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x9390A0", Offset = "0x9384A0", VA = "0x1809390A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ClientUIOpenedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearObjectUid()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x939130", Offset = "0x938530", VA = "0x180939130", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x9391F0", Offset = "0x9385F0", VA = "0x1809391F0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ClientUIOpenedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x939270", Offset = "0x938670", VA = "0x180939270", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x9393C0", Offset = "0x9387C0", VA = "0x1809393C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x9397C0", Offset = "0x938BC0", VA = "0x1809397C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x938F90", Offset = "0x938390", VA = "0x180938F90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x939350", Offset = "0x938750", VA = "0x180939350", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClientUIOpenedEvent other)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x939700", Offset = "0x938B00", VA = "0x180939700", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
