using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification;

[Token(Token = "0x2000832")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientChallengeProofRequest : IMessage<ClientChallengeProofRequest>, IMessage, IEquatable<ClientChallengeProofRequest>, IDeepCloneable<ClientChallengeProofRequest>, IBufferMessage
{
	[Token(Token = "0x4001C3B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ClientChallengeProofRequest> _parser;

	[Token(Token = "0x4001C3C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C3D")]
	public const int ProofFieldNumber = 1;

	[Token(Token = "0x4001C3E")]
	[FieldOffset(Offset = "0x18")]
	private string proof_;

	[Token(Token = "0x17001283")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClientChallengeProofRequest> Parser
	{
		[Token(Token = "0x600570C")]
		[Address(RVA = "0xB08690", Offset = "0xB07A90", VA = "0x180B08690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001284")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600570D")]
		[Address(RVA = "0xB085E0", Offset = "0xB079E0", VA = "0x180B085E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001285")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600570E")]
		[Address(RVA = "0xB087A0", Offset = "0xB07BA0", VA = "0x180B087A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001286")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Proof
	{
		[Token(Token = "0x6005712")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005713")]
		[Address(RVA = "0xB08880", Offset = "0xB07C80", VA = "0x180B08880")]
		set
		{
		}
	}

	[Token(Token = "0x600570F")]
	[Address(RVA = "0xB084F0", Offset = "0xB078F0", VA = "0x180B084F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientChallengeProofRequest()
	{
	}

	[Token(Token = "0x6005710")]
	[Address(RVA = "0xB08540", Offset = "0xB07940", VA = "0x180B08540")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientChallengeProofRequest(ClientChallengeProofRequest other)
	{
	}

	[Token(Token = "0x6005711")]
	[Address(RVA = "0xB081B0", Offset = "0xB075B0", VA = "0x180B081B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ClientChallengeProofRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005714")]
	[Address(RVA = "0xB08280", Offset = "0xB07680", VA = "0x180B08280", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005715")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClientChallengeProofRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005716")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005717")]
	[Address(RVA = "0xB08390", Offset = "0xB07790", VA = "0x180B08390", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005718")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005719")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600571A")]
	[Address(RVA = "0xB08120", Offset = "0xB07520", VA = "0x180B08120", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600571B")]
	[Address(RVA = "0xB08330", Offset = "0xB07730", VA = "0x180B08330", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClientChallengeProofRequest other)
	{
	}

	[Token(Token = "0x600571C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600571D")]
	[Address(RVA = "0xB086E0", Offset = "0xB07AE0", VA = "0x180B086E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
