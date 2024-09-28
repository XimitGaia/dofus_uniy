using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000A2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPresetSpellMoveRequest : IMessage<TaxCollectorPresetSpellMoveRequest>, IMessage, IEquatable<TaxCollectorPresetSpellMoveRequest>, IDeepCloneable<TaxCollectorPresetSpellMoveRequest>, IBufferMessage
{
	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPresetSpellMoveRequest> _parser;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400021A")]
	public const int PresetUidFieldNumber = 1;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x18")]
	private string presetUid_;

	[Token(Token = "0x400021C")]
	public const int FromSlotIdFieldNumber = 2;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x20")]
	private int fromSlotId_;

	[Token(Token = "0x400021E")]
	public const int ToSlotIdFieldNumber = 3;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x24")]
	private int toSlotId_;

	[Token(Token = "0x17000146")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorPresetSpellMoveRequest> Parser
	{
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x956780", Offset = "0x955B80", VA = "0x180956780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000147")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x9566D0", Offset = "0x955AD0", VA = "0x1809566D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000148")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x9568C0", Offset = "0x955CC0", VA = "0x1809568C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000149")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PresetUid
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x9569A0", Offset = "0x955DA0", VA = "0x1809569A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700014A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FromSlotId
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700014B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ToSlotId
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x956680", Offset = "0x955A80", VA = "0x180956680")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetSpellMoveRequest()
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x9565D0", Offset = "0x9559D0", VA = "0x1809565D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetSpellMoveRequest(TaxCollectorPresetSpellMoveRequest other)
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x956250", Offset = "0x955650", VA = "0x180956250", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetSpellMoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x956330", Offset = "0x955730", VA = "0x180956330", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x954650", Offset = "0x953A50", VA = "0x180954650", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorPresetSpellMoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x9546D0", Offset = "0x953AD0", VA = "0x1809546D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x956470", Offset = "0x955870", VA = "0x180956470", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x954C50", Offset = "0x954050", VA = "0x180954C50", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x956170", Offset = "0x955570", VA = "0x180956170", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x9563F0", Offset = "0x9557F0", VA = "0x1809563F0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorPresetSpellMoveRequest other)
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x9567D0", Offset = "0x955BD0", VA = "0x1809567D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
