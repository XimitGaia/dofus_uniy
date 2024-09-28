using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CFB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NuggetsDistributionRequest : IMessage<NuggetsDistributionRequest>, IMessage, IEquatable<NuggetsDistributionRequest>, IDeepCloneable<NuggetsDistributionRequest>, IBufferMessage
{
	[Token(Token = "0x4002FC1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NuggetsDistributionRequest> _parser;

	[Token(Token = "0x4002FC2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FC3")]
	public const int BeneficiariesFieldNumber = 1;

	[Token(Token = "0x4002FC4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<NuggetsBeneficiary> _repeated_beneficiaries_codec;

	[Token(Token = "0x4002FC5")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<NuggetsBeneficiary> beneficiaries_;

	[Token(Token = "0x17001DE5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NuggetsDistributionRequest> Parser
	{
		[Token(Token = "0x60088C6")]
		[Address(RVA = "0xCB5390", Offset = "0xCB4790", VA = "0x180CB5390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DE6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60088C7")]
		[Address(RVA = "0xCB52E0", Offset = "0xCB46E0", VA = "0x180CB52E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DE7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60088C8")]
		[Address(RVA = "0xCB55A0", Offset = "0xCB49A0", VA = "0x180CB55A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DE8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<NuggetsBeneficiary> Beneficiaries
	{
		[Token(Token = "0x60088CC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60088C9")]
	[Address(RVA = "0xCB51D0", Offset = "0xCB45D0", VA = "0x180CB51D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsDistributionRequest()
	{
	}

	[Token(Token = "0x60088CA")]
	[Address(RVA = "0xCB5250", Offset = "0xCB4650", VA = "0x180CB5250")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsDistributionRequest(NuggetsDistributionRequest other)
	{
	}

	[Token(Token = "0x60088CB")]
	[Address(RVA = "0xCB4D20", Offset = "0xCB4120", VA = "0x180CB4D20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NuggetsDistributionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60088CD")]
	[Address(RVA = "0xCB4E70", Offset = "0xCB4270", VA = "0x180CB4E70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088CE")]
	[Address(RVA = "0xCB4DE0", Offset = "0xCB41E0", VA = "0x180CB4DE0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NuggetsDistributionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088CF")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60088D0")]
	[Address(RVA = "0xCB4FD0", Offset = "0xCB43D0", VA = "0x180CB4FD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60088D1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60088D2")]
	[Address(RVA = "0xCB54F0", Offset = "0xCB48F0", VA = "0x180CB54F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60088D3")]
	[Address(RVA = "0xCB4C80", Offset = "0xCB4080", VA = "0x180CB4C80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60088D4")]
	[Address(RVA = "0xCB4F50", Offset = "0xCB4350", VA = "0x180CB4F50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NuggetsDistributionRequest other)
	{
	}

	[Token(Token = "0x60088D5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60088D6")]
	[Address(RVA = "0xCB53E0", Offset = "0xCB47E0", VA = "0x180CB53E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
