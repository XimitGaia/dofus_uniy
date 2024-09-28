using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200067F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeHandleMountsRequest : IMessage<ExchangeHandleMountsRequest>, IMessage, IEquatable<ExchangeHandleMountsRequest>, IDeepCloneable<ExchangeHandleMountsRequest>, IBufferMessage
{
	[Token(Token = "0x2000680")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000681")]
		public enum ExchangeHandleMountStableType
		{
			[Token(Token = "0x40016B8")]
			[OriginalName("EXCHANGE_MOUNT_STABLES_PUT")]
			ExchangeMountStablesPut,
			[Token(Token = "0x40016B9")]
			[OriginalName("EXCHANGE_MOUNT_STABLES_GET")]
			ExchangeMountStablesGet,
			[Token(Token = "0x40016BA")]
			[OriginalName("EXCHANGE_MOUNT_STABLES_FREE")]
			ExchangeMountStablesFree,
			[Token(Token = "0x40016BB")]
			[OriginalName("EXCHANGE_MOUNT_STABLES_CERTIF")]
			ExchangeMountStablesCertif,
			[Token(Token = "0x40016BC")]
			[OriginalName("EXCHANGE_MOUNT_STABLES_UNCERTIF")]
			ExchangeMountStablesUncertif,
			[Token(Token = "0x40016BD")]
			[OriginalName("EXCHANGE_MOUNT_PADDOCK_PUT")]
			ExchangeMountPaddockPut,
			[Token(Token = "0x40016BE")]
			[OriginalName("EXCHANGE_MOUNT_PADDOCK_GET")]
			ExchangeMountPaddockGet,
			[Token(Token = "0x40016BF")]
			[OriginalName("EXCHANGE_MOUNT_PADDOCK_FREE")]
			ExchangeMountPaddockFree,
			[Token(Token = "0x40016C0")]
			[OriginalName("EXCHANGE_EQUIPPED_MOUNT_PADDOCK_PUT")]
			ExchangeEquippedMountPaddockPut,
			[Token(Token = "0x40016C1")]
			[OriginalName("EXCHANGE_EQUIPPED_MOUNT_PADDOCK_GET")]
			ExchangeEquippedMountPaddockGet,
			[Token(Token = "0x40016C2")]
			[OriginalName("EXCHANGE_EQUIPPED_FREE")]
			ExchangeEquippedFree,
			[Token(Token = "0x40016C3")]
			[OriginalName("EXCHANGE_CERTIFICATE_FREE")]
			ExchangeCertificateFree,
			[Token(Token = "0x40016C4")]
			[OriginalName("EXCHANGE_EQUIPPED_CERTIF")]
			ExchangeEquippedCertif,
			[Token(Token = "0x40016C5")]
			[OriginalName("EXCHANGE_MOUNT_PADDOCK_CERTIF")]
			ExchangeMountPaddockCertif,
			[Token(Token = "0x40016C6")]
			[OriginalName("EXCHANGE_UNCERTIF_TO_EQUIPPED")]
			ExchangeUncertifToEquipped,
			[Token(Token = "0x40016C7")]
			[OriginalName("EXCHANGE_UNCERTIF_TO_PADDOCK")]
			ExchangeUncertifToPaddock,
			[Token(Token = "0x40016C8")]
			[OriginalName("EXCHANGE_MOUNT_STABLES_STERILIZE")]
			ExchangeMountStablesSterilize,
			[Token(Token = "0x40016C9")]
			[OriginalName("EXCHANGE_EQUIPPED_STERILIZE")]
			ExchangeEquippedSterilize,
			[Token(Token = "0x40016CA")]
			[OriginalName("EXCHANGE_MOUNT_PADDOCK_STERILIZE")]
			ExchangeMountPaddockSterilize
		}
	}

	[Token(Token = "0x40016B0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeHandleMountsRequest> _parser;

	[Token(Token = "0x40016B1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016B2")]
	public const int ActionTypeFieldNumber = 1;

	[Token(Token = "0x40016B3")]
	[FieldOffset(Offset = "0x18")]
	private Types.ExchangeHandleMountStableType actionType_;

	[Token(Token = "0x40016B4")]
	public const int RidesIdFieldNumber = 2;

	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_ridesId_codec;

	[Token(Token = "0x40016B6")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> ridesId_;

	[Token(Token = "0x17000EE6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeHandleMountsRequest> Parser
	{
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0xA8A9D0", Offset = "0xA89DD0", VA = "0x180A8A9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EE7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0xA8A920", Offset = "0xA89D20", VA = "0x180A8A920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EE8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60045AF")]
		[Address(RVA = "0xA8AC20", Offset = "0xA8A020", VA = "0x180A8AC20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EE9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ExchangeHandleMountStableType ActionType
	{
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.ExchangeHandleMountStableType);
		}
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000EEA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RidesId
	{
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60045B0")]
	[Address(RVA = "0xA8A810", Offset = "0xA89C10", VA = "0x180A8A810")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeHandleMountsRequest()
	{
	}

	[Token(Token = "0x60045B1")]
	[Address(RVA = "0xA8A890", Offset = "0xA89C90", VA = "0x180A8A890")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeHandleMountsRequest(ExchangeHandleMountsRequest other)
	{
	}

	[Token(Token = "0x60045B2")]
	[Address(RVA = "0xA8A3B0", Offset = "0xA897B0", VA = "0x180A8A3B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeHandleMountsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60045B6")]
	[Address(RVA = "0xA8A510", Offset = "0xA89910", VA = "0x180A8A510", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045B7")]
	[Address(RVA = "0xA8A470", Offset = "0xA89870", VA = "0x180A8A470", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeHandleMountsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045B8")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60045B9")]
	[Address(RVA = "0xA8A680", Offset = "0xA89A80", VA = "0x180A8A680", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60045BA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60045BB")]
	[Address(RVA = "0xA8AB50", Offset = "0xA89F50", VA = "0x180A8AB50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60045BC")]
	[Address(RVA = "0xA8A2D0", Offset = "0xA896D0", VA = "0x180A8A2D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60045BD")]
	[Address(RVA = "0xA8A5F0", Offset = "0xA899F0", VA = "0x180A8A5F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeHandleMountsRequest other)
	{
	}

	[Token(Token = "0x60045BE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60045BF")]
	[Address(RVA = "0xA8AA20", Offset = "0xA89E20", VA = "0x180A8AA20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
