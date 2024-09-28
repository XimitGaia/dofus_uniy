using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001FD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetSetRequest : IMessage<ForgettableSpellPresetSetRequest>, IMessage, IEquatable<ForgettableSpellPresetSetRequest>, IDeepCloneable<ForgettableSpellPresetSetRequest>, IBufferMessage
{
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetSetRequest> _parser;

	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006C5")]
	public const int UuidFieldNumber = 1;

	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x18")]
	private string uuid_;

	[Token(Token = "0x40006C7")]
	public const int OriginFieldNumber = 2;

	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x20")]
	private PresetOrigin origin_;

	[Token(Token = "0x17000452")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellPresetSetRequest> Parser
	{
		[Token(Token = "0x600142D")]
		[Address(RVA = "0xCDFF80", Offset = "0xCDF380", VA = "0x180CDFF80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000453")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600142E")]
		[Address(RVA = "0xCDFED0", Offset = "0xCDF2D0", VA = "0x180CDFED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000454")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600142F")]
		[Address(RVA = "0xCE0110", Offset = "0xCDF510", VA = "0x180CE0110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000455")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001434")]
		[Address(RVA = "0xCE01F0", Offset = "0xCDF5F0", VA = "0x180CE01F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000456")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOrigin Origin
	{
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001430")]
	[Address(RVA = "0xCDFDC0", Offset = "0xCDF1C0", VA = "0x180CDFDC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetSetRequest()
	{
	}

	[Token(Token = "0x6001431")]
	[Address(RVA = "0xCDFE10", Offset = "0xCDF210", VA = "0x180CDFE10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetSetRequest(ForgettableSpellPresetSetRequest other)
	{
	}

	[Token(Token = "0x6001432")]
	[Address(RVA = "0xCDF9C0", Offset = "0xCDEDC0", VA = "0x180CDF9C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001437")]
	[Address(RVA = "0xCDFAB0", Offset = "0xCDEEB0", VA = "0x180CDFAB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001438")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001439")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600143A")]
	[Address(RVA = "0xCDFC60", Offset = "0xCDF060", VA = "0x180CDFC60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600143B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600143C")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600143D")]
	[Address(RVA = "0xCDF900", Offset = "0xCDED00", VA = "0x180CDF900", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600143E")]
	[Address(RVA = "0xCDFB70", Offset = "0xCDEF70", VA = "0x180CDFB70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellPresetSetRequest other)
	{
	}

	[Token(Token = "0x600143F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0xCDFFD0", Offset = "0xCDF3D0", VA = "0x180CDFFD0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
