using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000089")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportDestination : IMessage<TeleportDestination>, IMessage, IEquatable<TeleportDestination>, IDeepCloneable<TeleportDestination>, IBufferMessage
{
	[Token(Token = "0x200008A")]
	public enum ComplementaryInformationOneofCase
	{
		[Token(Token = "0x40001D8")]
		None = 0,
		[Token(Token = "0x40001D9")]
		Anomaly = 6
	}

	[Token(Token = "0x200008B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200008C")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Anomaly : IMessage<Anomaly>, IMessage, IEquatable<Anomaly>, IDeepCloneable<Anomaly>, IBufferMessage
		{
			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Anomaly> _parser;

			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40001DC")]
			public const int BonusPourcentageFieldNumber = 1;

			[Token(Token = "0x40001DD")]
			[FieldOffset(Offset = "0x18")]
			private int bonusPourcentage_;

			[Token(Token = "0x40001DE")]
			public const int RemainingTimeFieldNumber = 2;

			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x20")]
			private long remainingTime_;

			[Token(Token = "0x17000118")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Anomaly> Parser
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0x950E80", Offset = "0x950280", VA = "0x180950E80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000119")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600051C")]
				[Address(RVA = "0x950E00", Offset = "0x950200", VA = "0x180950E00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600051D")]
				[Address(RVA = "0x951000", Offset = "0x950400", VA = "0x180951000", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int BonusPourcentage
			{
				[Token(Token = "0x6000521")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000522")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x1700011C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long RemainingTime
			{
				[Token(Token = "0x6000523")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000524")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x600051E")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Anomaly()
			{
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Anomaly(Anomaly other)
			{
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x9509E0", Offset = "0x94FDE0", VA = "0x1809509E0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Anomaly Clone()
			{
				return null;
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x950AB0", Offset = "0x94FEB0", VA = "0x180950AB0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Anomaly other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x950C40", Offset = "0x950040", VA = "0x180950C40", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x950920", Offset = "0x94FD20", VA = "0x180950920", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Anomaly other)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportDestination> _parser;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001CA")]
	public const int TypeFieldNumber = 1;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x18")]
	private Teleporter type_;

	[Token(Token = "0x40001CC")]
	public const int MapIdFieldNumber = 2;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x40001CE")]
	public const int SubareaIdFieldNumber = 3;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x28")]
	private int subareaId_;

	[Token(Token = "0x40001D0")]
	public const int LevelFieldNumber = 4;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x2C")]
	private int level_;

	[Token(Token = "0x40001D2")]
	public const int CostFieldNumber = 5;

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x30")]
	private int cost_;

	[Token(Token = "0x40001D4")]
	public const int AnomalyFieldNumber = 6;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x38")]
	private object complementaryInformation_;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x40")]
	private ComplementaryInformationOneofCase complementaryInformationCase_;

	[Token(Token = "0x1700010E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TeleportDestination> Parser
	{
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x95FC00", Offset = "0x95F000", VA = "0x18095FC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x95FB40", Offset = "0x95EF40", VA = "0x18095FB40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000110")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x95FF90", Offset = "0x95F390", VA = "0x18095FF90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000111")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Teleporter Type
	{
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Teleporter);
		}
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000112")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000113")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubareaId
	{
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000114")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level
	{
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17000115")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Cost
	{
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17000116")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Anomaly Anomaly
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x95FAD0", Offset = "0x95EED0", VA = "0x18095FAD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x95FFD0", Offset = "0x95F3D0", VA = "0x18095FFD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000117")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ComplementaryInformationOneofCase ComplementaryInformationCase
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
		get
		{
			return default(ComplementaryInformationOneofCase);
		}
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportDestination()
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x95F970", Offset = "0x95ED70", VA = "0x18095F970")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportDestination(TeleportDestination other)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x95F150", Offset = "0x95E550", VA = "0x18095F150", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportDestination Clone()
	{
		return null;
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x95F130", Offset = "0x95E530", VA = "0x18095F130")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComplementaryInformation()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x95F3A0", Offset = "0x95E7A0", VA = "0x18095F3A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x95F2E0", Offset = "0x95E6E0", VA = "0x18095F2E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TeleportDestination other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x95F4A0", Offset = "0x95E8A0", VA = "0x18095F4A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x95F810", Offset = "0x95EC10", VA = "0x18095F810", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x95FE50", Offset = "0x95F250", VA = "0x18095FE50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x95EF90", Offset = "0x95E390", VA = "0x18095EF90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x95F5E0", Offset = "0x95E9E0", VA = "0x18095F5E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TeleportDestination other)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x95FC50", Offset = "0x95F050", VA = "0x18095FC50", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
