using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C70")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationListEvent : IMessage<AllianceApplicationListEvent>, IMessage, IEquatable<AllianceApplicationListEvent>, IDeepCloneable<AllianceApplicationListEvent>, IBufferMessage
{
	[Token(Token = "0x4002DF5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationListEvent> _parser;

	[Token(Token = "0x4002DF6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DF7")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x4002DF8")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4002DF9")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4002DFA")]
	[FieldOffset(Offset = "0x20")]
	private long count_;

	[Token(Token = "0x4002DFB")]
	public const int TotalFieldNumber = 3;

	[Token(Token = "0x4002DFC")]
	[FieldOffset(Offset = "0x28")]
	private long total_;

	[Token(Token = "0x4002DFD")]
	public const int AppliesFieldNumber = 4;

	[Token(Token = "0x4002DFE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<SocialApplicationInformation> _repeated_applies_codec;

	[Token(Token = "0x4002DFF")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<SocialApplicationInformation> applies_;

	[Token(Token = "0x17001CAC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationListEvent> Parser
	{
		[Token(Token = "0x60082E3")]
		[Address(RVA = "0xC70940", Offset = "0xC6FD40", VA = "0x180C70940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CAD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60082E4")]
		[Address(RVA = "0xC70890", Offset = "0xC6FC90", VA = "0x180C70890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CAE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60082E5")]
		[Address(RVA = "0xC70C20", Offset = "0xC70020", VA = "0x180C70C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CAF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Offset
	{
		[Token(Token = "0x60082E9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60082EA")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001CB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Count
	{
		[Token(Token = "0x60082EB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60082EC")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001CB1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Total
	{
		[Token(Token = "0x60082ED")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60082EE")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17001CB2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SocialApplicationInformation> Applies
	{
		[Token(Token = "0x60082EF")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60082E6")]
	[Address(RVA = "0xC70760", Offset = "0xC6FB60", VA = "0x180C70760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationListEvent()
	{
	}

	[Token(Token = "0x60082E7")]
	[Address(RVA = "0xC707E0", Offset = "0xC6FBE0", VA = "0x180C707E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationListEvent(AllianceApplicationListEvent other)
	{
	}

	[Token(Token = "0x60082E8")]
	[Address(RVA = "0xC70240", Offset = "0xC6F640", VA = "0x180C70240", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60082F0")]
	[Address(RVA = "0xC703C0", Offset = "0xC6F7C0", VA = "0x180C703C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60082F1")]
	[Address(RVA = "0xC70310", Offset = "0xC6F710", VA = "0x180C70310", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60082F2")]
	[Address(RVA = "0x9DD5E0", Offset = "0x9DC9E0", VA = "0x1809DD5E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60082F3")]
	[Address(RVA = "0xC70560", Offset = "0xC6F960", VA = "0x180C70560", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60082F4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60082F5")]
	[Address(RVA = "0xC70B00", Offset = "0xC6FF00", VA = "0x180C70B00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60082F6")]
	[Address(RVA = "0xC70100", Offset = "0xC6F500", VA = "0x180C70100", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60082F7")]
	[Address(RVA = "0xC704B0", Offset = "0xC6F8B0", VA = "0x180C704B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceApplicationListEvent other)
	{
	}

	[Token(Token = "0x60082F8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60082F9")]
	[Address(RVA = "0xC70990", Offset = "0xC6FD90", VA = "0x180C70990", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
