using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000543")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameRolePlayShowActorsEvent : IMessage<GameRolePlayShowActorsEvent>, IMessage, IEquatable<GameRolePlayShowActorsEvent>, IDeepCloneable<GameRolePlayShowActorsEvent>, IBufferMessage
{
	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameRolePlayShowActorsEvent> _parser;

	[Token(Token = "0x4001204")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001205")]
	public const int ActorsFieldNumber = 1;

	[Token(Token = "0x4001206")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ActorPositionInformation> _repeated_actors_codec;

	[Token(Token = "0x4001207")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ActorPositionInformation> actors_;

	[Token(Token = "0x17000BDD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameRolePlayShowActorsEvent> Parser
	{
		[Token(Token = "0x60037DB")]
		[Address(RVA = "0x9FAD20", Offset = "0x9FA120", VA = "0x1809FAD20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BDE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60037DC")]
		[Address(RVA = "0x9FAC70", Offset = "0x9FA070", VA = "0x1809FAC70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BDF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60037DD")]
		[Address(RVA = "0x9FAF30", Offset = "0x9FA330", VA = "0x1809FAF30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ActorPositionInformation> Actors
	{
		[Token(Token = "0x60037E1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60037DE")]
	[Address(RVA = "0x9FABF0", Offset = "0x9F9FF0", VA = "0x1809FABF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameRolePlayShowActorsEvent()
	{
	}

	[Token(Token = "0x60037DF")]
	[Address(RVA = "0x9FAB60", Offset = "0x9F9F60", VA = "0x1809FAB60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameRolePlayShowActorsEvent(GameRolePlayShowActorsEvent other)
	{
	}

	[Token(Token = "0x60037E0")]
	[Address(RVA = "0x9FA6B0", Offset = "0x9F9AB0", VA = "0x1809FA6B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameRolePlayShowActorsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60037E2")]
	[Address(RVA = "0x9FA770", Offset = "0x9F9B70", VA = "0x1809FA770", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60037E3")]
	[Address(RVA = "0x9FA850", Offset = "0x9F9C50", VA = "0x1809FA850", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameRolePlayShowActorsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60037E4")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60037E5")]
	[Address(RVA = "0x9FA960", Offset = "0x9F9D60", VA = "0x1809FA960", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60037E6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60037E7")]
	[Address(RVA = "0x9FAE80", Offset = "0x9FA280", VA = "0x1809FAE80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60037E8")]
	[Address(RVA = "0x9FA610", Offset = "0x9F9A10", VA = "0x1809FA610", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60037E9")]
	[Address(RVA = "0x9FA8E0", Offset = "0x9F9CE0", VA = "0x1809FA8E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameRolePlayShowActorsEvent other)
	{
	}

	[Token(Token = "0x60037EA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60037EB")]
	[Address(RVA = "0x9FAD70", Offset = "0x9FA170", VA = "0x1809FAD70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
